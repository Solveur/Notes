namespace Notes
{
	using Notes.Forms;
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SQLite;
	using System.Drawing;
	using System.IO;
	using System.Windows.Forms;

	public partial class Main_Form: Form
	{
		// TODO: не убирается фон после смены пользователя
		static string strCon = "Data Source =  Notes.db; Version = 3";
		SQLiteConnection con = new SQLiteConnection(strCon);

		List<Note> Notes = new List<Note>();
		Note SelectedNote = null;

		List<User> Users = new List<User>();
		User CurrentUser = null;

		public Main_Form()
		{
			InitializeComponent();
			CreateTablesIfNotExist();
			Users = GetUsers();
			Notes = GetAllNotes();
			ConnectNotesAndUsers(Users);
			SetTooltips();
			DragWindowByMenuStrip();
			ColorMenuStrip();
			richTextBox_NoteText.Visible = !(SelectedNote is null);
			button_AddNote.Enabled = !(CurrentUser is null);
		}

		void SelectNote(object sender)
		{
			//TODO: Polymorphism
			if(sender is Note note)
			{
				if(SelectedNote != null)
					SelectedNote.BackColor = Color.Transparent;
				SelectedNote = note;
				SelectedNote.BackColor = Color.FromArgb(224, 114, 76);
				richTextBox_NoteText.Visible = true;
				richTextBox_NoteText.Rtf = note.RTF;
				richTextBox_NoteText.Focus();
			}
			else if(sender is Label label)
			{
				if(SelectedNote != null)
					SelectedNote.BackColor = Color.Transparent;
				SelectedNote = label.Parent as Note;
				SelectedNote.BackColor = Color.FromArgb(223, 74, 22);
				richTextBox_NoteText.Visible = true;
				richTextBox_NoteText.Rtf = (label.Parent as Note).RTF;
				richTextBox_NoteText.Focus();
			}
		}

		void Note_Click(object sender, EventArgs e)
		{
			SelectNote(sender);
		}

		void Button_AddNote_Click(object sender, EventArgs e)
		{
			Note note = new Note
			{
				Owner = CurrentUser
			};
			note.Click += new EventHandler(Note_Click);
			Notes.Add(note);
			CurrentUser.Notes.Add(note);
			flowLayoutPanel_Notes.Controls.Add(note);
		}

		void RichTextBox_NoteText_TextChanged(object sender, EventArgs e)
		{
			SelectedNote.RTF =
			 SelectedNote is null ? string.Empty : richTextBox_NoteText.Rtf;
		}

		void showUsersControlPanelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(UsersList_Form usersList = new UsersList_Form())
			{
				usersList.Users = Users;
				usersList.Owner = this;
				usersList.UpdateList();
				usersList.ShowDialog();
			}
		}

		void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveNotes(Notes);
		}

		void SaveNotes(List<Note> notes)
		{
			if(con.State == ConnectionState.Closed)
				con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				foreach(var note in notes)
				{
					command.Parameters.AddWithValue("@rowid", note.Rowid);
					command.Parameters.AddWithValue("@owner", note.Owner.Rowid);
					command.Parameters.AddWithValue("@note", note.RTF);
					command.Parameters.AddWithValue("@dateOfCreate", note.DateOfCreation);

					if(note.IsNew)
					{
						command.CommandText = "INSERT INTO Notes(owner, note, dateOfCreate) VALUES(@owner, @note, @dateOfCreate)";
					}
					else
					{
						command.CommandText = "UPDATE Notes SET note=@note, owner=@owner WHERE id=@rowid";
					}

					try
					{
						command.ExecuteNonQuery();
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
				}
			}
			con.Close();
		}

		List<Note> GetNotesForUser(User user)
		{
			List<Note> asd = new List<Note>();
			foreach(var note in Notes)
			{
				if(note.Owner.Rowid == user.Rowid)
					asd.Add(note);
			}
			return asd;
		}

		List<Note> GetAllNotes()
		{
			if(con.State == ConnectionState.Closed)
				con.Open();

			List<Note> notes = new List<Note>();
			using(SQLiteCommand command = con.CreateCommand())
			{
				command.CommandText = $"SELECT id, owner, note, dateOfCreate FROM Notes";
				try
				{
					SQLiteDataReader r = command.ExecuteReader();

					while(r.Read())
					{
						User owner = new User();
						foreach(var targetUser in Users)
						{
							if(targetUser.Rowid == Convert.ToInt32(r["owner"]))
							{
								owner = targetUser;
								break;
							}
						}
						Note note = new Note()
						{
							Owner = owner,
							RTF = r["note"].ToString(),
							Rowid = Convert.ToInt32(r["id"]),
							DateOfCreation = Convert.ToDateTime(r["dateOfCreate"].ToString()),
							IsNew = false,
						};
						note.Click += new EventHandler(Note_Click);
						notes.Add(note);
					}
					r.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
			return notes;
		}

		List<User> GetUsers()
		{
			if(con.State == ConnectionState.Closed)
				con.Open();

			List<User> users = new List<User>();
			using(SQLiteCommand command = con.CreateCommand())
			{
				command.CommandText = $"SELECT id, login, description, avatar FROM Users";
				try
				{
					SQLiteDataReader r = command.ExecuteReader();

					while(r.Read())
					{
						User newUser = new User()
						{
							Rowid = Convert.ToInt32(r["id"]),
							Login = r["login"].ToString(),
							Description = r["description"].ToString(),
							Avatar = ByteToImage((byte[])r["avatar"]),
							IsNew = false,
						};
						users.Add(newUser);
					}
					r.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
			return users;
		}

		void SetTooltips()
		{
			ToolTip tip = new ToolTip();
			tip.SetToolTip(button_AddNote, "Add note");
		}

		void DragWindowByMenuStrip()
		{
			menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler((sender, e) =>
			{
				Capture = false;
				Message message = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
				WndProc(ref message);
			});
		}

		void ColorMenuStrip()
		{
			menuStrip.Renderer = new ToolStripProfessionalRenderer(new MenuStripRenderer());
		}

		Image ByteToImage(byte[] imageBytes)
		{
			// Convert byte[] to Image
			MemoryStream ms = new MemoryStream(imageBytes);
			System.Drawing.Image image = new Bitmap(ms);
			return image;
		}

		void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void SetCurrentUser(User user)
		{
			if(CurrentUser == user)
				return;

			CurrentUser = user;
			List<Note> notesForUser = new List<Note>();
			notesForUser = CurrentUser is null ? notesForUser : CurrentUser.Notes;
			richTextBox_NoteText.Visible = false;
			flowLayoutPanel_Notes.Controls.Clear();
			flowLayoutPanel_Notes.Controls.AddRange(notesForUser.ToArray());
			SetLabelUser(user);
			button_AddNote.Enabled = !(CurrentUser is null);
		}

		void ConnectNotesAndUsers(List<User> users)
		{
			foreach(var user in users)
				user.Notes = GetNotesForUser(user);
		}

		void SetLabelUser(User user)
		{
			if(user is null)
			{
				labelCurrentUser.Text = "Current user: ";
				return;
			}
			labelCurrentUser.Text = $"Current user: {user.Login}";
		}

		void CreateTablesIfNotExist()
		{
			if(con.State == ConnectionState.Closed)
				con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				command.CommandText = "CREATE TABLE IF NOT EXISTS [Users](" +
					"[id] INTEGER PRIMARY KEY ASC ON CONFLICT ROLLBACK AUTOINCREMENT NOT NULL ON CONFLICT ROLLBACK UNIQUE ON CONFLICT ROLLBACK," +
					"[login] TEXT NOT NULL ON CONFLICT ROLLBACK," +
					"[description] TEXT," +
					"[avatar] BINARY);" +

					"CREATE TABLE IF NOT EXISTS [Notes](" +
					"[id] INTEGER PRIMARY KEY ASC ON CONFLICT ROLLBACK AUTOINCREMENT NOT NULL ON CONFLICT ROLLBACK UNIQUE ON CONFLICT ROLLBACK," +
					"[owner] INT NOT NULL ON CONFLICT ROLLBACK REFERENCES[Users]([id]) ON DELETE CASCADE ON UPDATE CASCADE," +
					"[note] TEXT," +
					"[dateOfCreate] DATETIME NOT NULL ON CONFLICT ROLLBACK);";
				command.ExecuteNonQuery();
			}
		}
	}
}