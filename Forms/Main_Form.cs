using Notes.Forms;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Notes
{
	public partial class Main_Form : Form
	{
		string strCon = "Data Source =  Notes.db; Version = 3";

		List<Note> Notes = new List<Note>();
		Note SelectedNote = null;

		//TODO: Change user select
		List<User> Users = new List<User>();
		private User CurrentUser = null;

		public Main_Form()
		{
			InitializeComponent();
			Users = GetUsers();
			Notes = GetAllNotes();
			ConnectNotesAndUsers(Users);
			SetTooltips();
			DragWindowByMenuStrip();
			ColorMenuStrip();
			richTextBox_NoteText.Visible = !(SelectedNote is null);
			button_AddNote.Enabled = !(CurrentUser is null);
		}

		void Note_Click(object sender, EventArgs e)
		{
			SelectNote(sender);
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

		void Button_AddNote_Click(object sender, EventArgs e)
		{
			Note note = new Note()
			{
				Owner = CurrentUser,
				DateOfCreation = DateTime.Now
			};
			note.Click += new EventHandler(Note_Click);
			Notes.Add(note);
			flowLayoutPanel_Notes.Controls.Add(note);
			CurrentUser.Notes.Add(note);
		}

		void RichTextBox_NoteText_TextChanged(object sender, EventArgs e)
		{
			if (SelectedNote != null)
				SelectedNote.RTF = richTextBox_NoteText.Rtf;
		}

		void СomboBox_User_SelectionChangeCommitted(object sender, EventArgs e)
		{
			User newUser = (sender as ComboBox).SelectedItem as User;
			if (newUser.Login == CurrentUser.Login)
				return;
			flowLayoutPanel_Notes.Controls.Clear();
			CurrentUser = newUser;
			List<Note> notesForUser = GetNotesForUser(CurrentUser);
			AddNotesToFlowPanel(notesForUser);
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
			Application.Exit();
		}

		void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveNotes(Notes);
			SaveUsers(Users);
		}

		void AddNotesToFlowPanel(List<Note> notes)
		{
			foreach (var note in notes)
			{
				flowLayoutPanel_Notes.Controls.Add(note);
				note.Click += Note_Click;
			}
		}

		void SaveNotes(List<Note> notes)
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
			if(con.State == ConnectionState.Closed)
				con.Open();

			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					foreach (var note in notes)
					{
						if (note.Rowid == 0)
						{
							command.CommandText = $"INSERT INTO Notes(owner, note, dateOfCreate) VALUES('{note.Owner.Rowid}', '{note.RTF}', '{note.DateOfCreation:yyyy-MM-dd hh:mm:ss}')";
							command.ExecuteNonQuery();
						}
						else
						{
							command.CommandText = $"UPDATE Notes SET note = '{note.RTF}' WHERE rowid = '{note.Rowid}'";
							command.ExecuteNonQuery();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
		}

		void SaveUsers(List<User> users)
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
			con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				foreach(var user in users)
				{
					SQLiteParameter avatar = new SQLiteParameter("@avatar", DbType.Binary)
					{
						Value = ImageToByte(user.Image, user.Image.RawFormat)
					};
					command.Parameters.Add(avatar);
					command.Parameters.AddWithValue("@login", user.Login);
					command.Parameters.AddWithValue("@description", user.Description);
					command.Parameters.AddWithValue("@rowid", user.Rowid);
					if(user.Rowid == 0)
					{
						command.CommandText = "INSERT INTO Users(login, description, avatar) VALUES(@login, @description, @avatar)";
					}
					else
					{
						command.CommandText = "UPDATE Users SET login=@login, description=@description, avatar=@avatar WHERE rowid=@rowid";
					}
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
			con.Close();
		}

		List<Note> GetNotesForUser(User user)
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
			if(con.State == ConnectionState.Closed)
				con.Open();
			List<Note> notes = new List<Note>();

			using(SQLiteCommand command = con.CreateCommand())
			{
				command.CommandText = $"SELECT owner, note, rowid, dateOfCreate FROM Notes WHERE owner = '{user.Rowid}'";
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
						Rowid = Convert.ToInt32(r["rowid"]),
						DateOfCreation = Convert.ToDateTime(r["dateOfCreate"])
					};
					richTextBox_NoteText.Rtf = note.RTF;
					notes.Add(note);
				}
				r.Close();
				richTextBox_NoteText.Text = "";
				try
				{
					command.ExecuteNonQuery();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
			return notes;
		}

		List<Note> GetAllNotes()
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
			if(con.State == ConnectionState.Closed)
				con.Open();
			List<Note> notes = new List<Note>();

			using(SQLiteCommand command = con.CreateCommand())
			{
				command.CommandText = $"SELECT owner, note, rowid, dateOfCreate FROM Notes";
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
						Rowid = Convert.ToInt32(r["rowid"]),
						DateOfCreation = Convert.ToDateTime(r["dateOfCreate"].ToString())
					};
					richTextBox_NoteText.Rtf = note.RTF;
					notes.Add(note);
				}
				r.Close();
				richTextBox_NoteText.Text = "";
				try
				{
					command.ExecuteNonQuery();
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
			SQLiteConnection con = new SQLiteConnection(strCon);
			if(con.State == ConnectionState.Closed)
				con.Open();
			List<User> users = new List<User>();
			using(SQLiteCommand command = con.CreateCommand())
			{
				command.CommandText = $"SELECT rowid, login, description, avatar FROM Users";
				try
				{
					SQLiteDataReader r = command.ExecuteReader();

					while(r.Read())
					{
						User newUser = new User()
						{
							Rowid = Convert.ToInt32(r["rowid"]),
							Login = r["login"].ToString(),
							Description = r["description"].ToString(),
							Image = ByteToImage((byte[])r["avatar"]),
						};
						newUser.Notes = GetNotesForUser(newUser);
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
			//Add tooltips to Form_main buttons
			ToolTip tip = new ToolTip();
			tip.SetToolTip(button_AddNote, "Add note");
		}

		void DragWindowByMenuStrip()
		{
			menuStrip.MouseDown += new MouseEventHandler((sender, e) =>
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

		private byte[] ImageToByte(Image image, ImageFormat format)
		{
			using(MemoryStream ms = new MemoryStream())
			{
				// Convert Image to byte[]
				image.Save(ms, format);
				byte[] imageBytes = ms.ToArray();
				return imageBytes;
			}
		}
		//public Image Base64ToImage(string base64String)
		Image ByteToImage(byte[] imageBytes)
		{
			// Convert byte[] to Image
			MemoryStream ms = new MemoryStream(imageBytes);
			Image image = new Bitmap(ms);
			return image;
		}

		void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void ChangeCurrentUser(User user) //Do not delete
		{
			if(CurrentUser == user)
				return;

			CurrentUser = user;
			richTextBox_NoteText.Visible = false;
			flowLayoutPanel_Notes.Controls.Clear();
			flowLayoutPanel_Notes.Controls.AddRange(CurrentUser.Notes.ToArray());
			SetLabelUser(user);
			button_AddNote.Enabled = !(CurrentUser is null);
		}

		void ConnectNotesAndUsers(List<User> users)
		{
			foreach(var user in users)
			{
				user.Notes = GetNotesForUser(user);
			}
		}

		void SetLabelUser(User user)
		{
			labelCurrentUser.Text = $"Current user: {user.Login}";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SaveUsers(Users);
		}
	}
}