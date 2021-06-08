using Notes.Forms;
using NotesLib;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notes
{
	public partial class Main : Form
	{
		public string strCon = "Data Source =  Notes.db; Version = 3";

		public List<Note> Notes = new List<Note>();
		public Note SelectedNote = null;

		//TODO: Change user select
		public List<User> Users = new List<User>();
		public User CurrentUser = new User();


		public Main()
		{
			InitializeComponent();
			Users = GetUsers();
			SetTooltips();
			DragWindowByMenuStrip();
			ColorMenuStrip();
			if (SelectedNote == null)
			{
				richTextBox_NoteText.Visible = false;
			}
		}

		public void SelectNote(object sender, EventArgs e)
		{
			//TODO: Polymorphism
			if (sender is Note note)
			{
				if (SelectedNote != null)
				{
					//selectedNote.BorderStyle = BorderStyle.FixedSingle;
					SelectedNote.BackColor = Color.Transparent;
				}
				SelectedNote = note;
				//selectedNote.BorderStyle = BorderStyle.Fixed3D;
				SelectedNote.BackColor = Color.FromArgb(224, 114, 76);
				richTextBox_NoteText.Visible = true;
				richTextBox_NoteText.Rtf = note.RTF;
				richTextBox_NoteText.Focus();
			}
			else if (sender is Label label)
			{
				if (SelectedNote != null)
				{
					//selectedNote.BorderStyle = BorderStyle.FixedSingle;
					SelectedNote.BackColor = Color.Transparent;
				}
				SelectedNote = label.Parent as Note;
				//selectedNote.BorderStyle = BorderStyle.Fixed3D;
				SelectedNote.BackColor = Color.FromArgb(223, 74, 22);
				richTextBox_NoteText.Visible = true;
				richTextBox_NoteText.Rtf = (label.Parent as Note).RTF;
				richTextBox_NoteText.Focus();
			}
		}

		private void Button_AddNote_Click(object sender, EventArgs e)
		{
			Note note = new Note()
			{
				Owner = CurrentUser,
				DateOfCreation = DateTime.Now
			};
			note.Click += new EventHandler(SelectNote);
			Notes.Add(note);
			notesFlowPanel.Controls.Add(note);
		}

		private void Button_DeleteNote_Click(object sender, EventArgs e)
		{
			if (Notes.Count <= 0)
				return;
			if (MessageBox.Show("Do you want to delete this note?", "Deleting confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
				return;
			SQLiteConnection con;
			con = new SQLiteConnection(strCon);
			con.Open();

			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"DELETE from Notes WHERE rowid = '{SelectedNote.Rowid}'";
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();

			try
			{
				Notes.Remove(SelectedNote);
				notesFlowPanel.Controls.Remove(SelectedNote);
				SelectNote(Notes[0], e);
			}
			catch
			{
				richTextBox_NoteText.Visible = false;
			}

		}

		private void RichTextBox_NoteText_TextChanged(object sender, EventArgs e)
		{
			if (SelectedNote != null)
			{
				SelectedNote.RTF = richTextBox_NoteText.Rtf;
			}
		}

		private void СomboBox_User_SelectionChangeCommitted(object sender, EventArgs e)
		{
			User newUser = (sender as ComboBox).SelectedItem as User;
			if (newUser.Login == CurrentUser.Login)
				return;
			notesFlowPanel.Controls.Clear();
			CurrentUser = newUser;
			List<Note> notesForUser = GetNotesForUser(CurrentUser);
			AddNotesToFlowPanel(notesForUser);
		}

		private void Form_Main_Load(object sender, EventArgs e)
		{
			Notes = GetAllNotes();
		}

		private void showUsersControlPanelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(UsersList_Form usersList = new UsersList_Form())
			{
				usersList.Users = Users;
				usersList.UpdateList();
				usersList.ShowDialog();
			}
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveNotes(Notes);
			SaveUsers(Users);
		}

		private void AddNotesToFlowPanel(List<Note> notes)
		{
			foreach (var note in notes)
			{
				notesFlowPanel.Controls.Add(note);
				note.Click += SelectNote;
			}
		}

		private void SaveNotes(List<Note> notes)
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
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

		private void SaveUsers(List<User> users)
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
			con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					foreach(var user in users)
					{
						SQLiteParameter param = new SQLiteParameter("@0", System.Data.DbType.Binary)
						{
							Value = ImageToByte(user.Image, user.Image.RawFormat)
						};
						command.Parameters.Add(param);

						if(user.Rowid == 0)
						{
							command.CommandText = $"INSERT INTO Users (login, description, avatar) VALUES('{user.Login}', '{user.Description}', @0)";
							command.ExecuteNonQuery();
						}
						else
						{
							command.CommandText = $"UPDATE Users SET login = '{user.Login}', description = '{user.Description}', avatar = @0 WHERE rowid = '{user.Rowid}'";
							command.ExecuteNonQuery();
						}
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
		}

		private List<Note> GetNotesForUser(User user)
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
			con.Open();
			List<Note> notes = new List<Note>();

			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"SELECT owner, note, rowid, dateOfCreate FROM Notes WHERE login = '{user.Login}'";
					SQLiteDataReader r = command.ExecuteReader();

					while (r.Read())
					{
						User owner = new User();
						foreach(var userTemp in Users)
						{
							if(userTemp.Rowid == Convert.ToInt32(r["owner"]))
							{
								owner = userTemp;
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
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
			return notes;
		}

		private List<Note> GetAllNotes()
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
			con.Open();
			List<Note> notes = new List<Note>();

			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"SELECT owner, note, rowid, dateOfCreate FROM Notes";
					SQLiteDataReader r = command.ExecuteReader();

					while (r.Read())
					{
						User owner = new User();
						foreach(var userTemp in Users)
						{
							if(userTemp.Rowid == Convert.ToInt32(r["owner"]))
							{
								owner = userTemp;
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
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
			return notes;
		}

		private List<User> GetUsers()
		{
			SQLiteConnection con = new SQLiteConnection(strCon);
			con.Open();
			List<User> users = new List<User>();
			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"SELECT rowid, login, description, avatar FROM Users";
					SQLiteDataReader r = command.ExecuteReader();

					while (r.Read())
					{
						User newUser = new User()
						{
							Rowid = Convert.ToInt32(r["_rowid_"]),
							Login = r["login"].ToString(),
							Description = r["description"].ToString(),
							Image = ByteToImage((byte[])r["avatar"])
						};
						users.Add(newUser);
					}
					r.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
			return users;
		}

		private void SetTooltips()
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

		public byte[] ImageToByte(Image image, ImageFormat format)
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
		public Image ByteToImage(byte[] imageBytes)
		{
			// Convert byte[] to Image
			MemoryStream ms = new MemoryStream(imageBytes);
			Image image = new Bitmap(ms);
			return image;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}