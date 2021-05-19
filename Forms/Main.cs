using NotesLib;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Notes
{
	public partial class Main : Form
	{
		public string connectionString = "Data Source =  Notes.db; Version = 3";
		public List<Note> deletedNotes = new List<Note>();

		public List<Note> notes = new List<Note>();
		public Note selectedNote = null;

		//TODO: Change user select
		public List<User> users = new List<User>();
		public User currentUser = new User();

		public static string masterPassword = "1234";

		public Main()
		{
			InitializeComponent();
			users = GetUsers();
			comboBox_User.DataSource = users;
			comboBox_User.DisplayMember = "login";
			SetTooltips();
			if (selectedNote == null)
			{
				richTextBox_NoteText.Visible = false;
			}
		}

		public void SelectNote(object sender, EventArgs e)
		{
			//TODO: Polymorphism
			if (sender is Note note)
			{
				if (selectedNote != null)
				{
					selectedNote.BorderStyle = BorderStyle.FixedSingle;
				}
				selectedNote = note;
				selectedNote.BorderStyle = BorderStyle.Fixed3D;
				richTextBox_NoteText.Visible = true;
				richTextBox_NoteText.Rtf = note.RTF;
				richTextBox_NoteText.Focus();
			}
			else if (sender is Label label)
			{
				if (selectedNote != null)
				{
					selectedNote.BorderStyle = BorderStyle.FixedSingle;
				}
				selectedNote = label.Parent as Note;
				selectedNote.BorderStyle = BorderStyle.Fixed3D;
				richTextBox_NoteText.Visible = true;
				richTextBox_NoteText.Rtf = (label.Parent as Note).RTF;
				richTextBox_NoteText.Focus();
			}
		}

		private void Button_AddNote_Click(object sender, EventArgs e)
		{
			Note note = new Note()
			{
				dateOfCreation = DateTime.Now
			};
			note.Click += new EventHandler(SelectNote);
			notes.Add(note);
			flowLayoutPanel.Controls.Add(note);
		}

		private void Button_DeleteNote_Click(object sender, EventArgs e)
		{
			if (notes.Count <= 0)
				return;
			if (MessageBox.Show("Do you want to delete this note?", "Deleting confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
				return;
			SQLiteConnection con;
			con = new SQLiteConnection(connectionString);
			con.Open();

			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"DELETE from Notes WHERE rowid = '{selectedNote.rowid}'";
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();

			deletedNotes.Add(selectedNote);

			try
			{
				notes.Remove(selectedNote);
				flowLayoutPanel.Controls.Remove(selectedNote);
				SelectNote(notes[0], e);
			}
			catch
			{
				richTextBox_NoteText.Visible = false;
			}

		}

		private void RichTextBox_NoteText_TextChanged(object sender, EventArgs e)
		{
			if (selectedNote != null)
			{
				selectedNote.RTF = richTextBox_NoteText.Rtf;
			}
		}

		public void SaveNotes(List<Note> notes)
		{
			SQLiteConnection con = new SQLiteConnection(connectionString);
			con.Open();

			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					foreach (var note in notes)
					{
						if (note.rowid == 0)
						{
							command.CommandText = $"INSERT INTO Notes(login, note, dateOfCreate) VALUES('{note.login}', '{note.RTF}', '{note.dateOfCreation:yyyy-MM-dd hh:mm:ss}')";
							command.ExecuteNonQuery();
						}
						else
						{
							command.CommandText = $"UPDATE Notes SET note = '{note.RTF}' WHERE rowid = '{note.rowid}'";
							command.ExecuteNonQuery();
						}
					}
				}
				catch { }
			}
			con.Close();
		}

		List<Note> GetAllNotes()
		{
			SQLiteConnection con = new SQLiteConnection(connectionString);
			con.Open();
			List<Note> notes = new List<Note>();

			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"SELECT login, note, rowid, dateOfCreate FROM Notes";
					SQLiteDataReader r = command.ExecuteReader();

					while (r.Read())
					{
						Note note = new Note()
						{
							login = r["login"].ToString(),
							RTF = r["note"].ToString(),
							rowid = Convert.ToInt32(r["rowid"]),
							dateOfCreation = Convert.ToDateTime(r["dateOfCreate"])
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

		List<Note> GetNotesForUser(User user)
		{
			SQLiteConnection con = new SQLiteConnection(connectionString);
			con.Open();
			List<Note> notes = new List<Note>();

			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"SELECT login, note, rowid, dateOfCreate FROM Notes WHERE login = '{user.login}'";
					SQLiteDataReader r = command.ExecuteReader();

					while (r.Read())
					{
						Note note = new Note()
						{
							login = r["login"].ToString(),
							RTF = r["note"].ToString(),
							rowid = Convert.ToInt32(r["rowid"]),
							dateOfCreation = Convert.ToDateTime(r["dateOfCreate"])
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

		private void Button_AddUser_Click(object sender, EventArgs e)
		{
			using (AddUser addUser = new AddUser())
			{
				addUser.ShowDialog();
			};
		}

		private void Button_RemoveUser_Click(object sender, EventArgs e)
		{
			using (DeleteUser deleteUser = new DeleteUser())
			{
				if (deleteUser.login != currentUser.login)
					return;
				Hide();
				richTextBox_NoteText.Text = "";
				comboBox_User.Text = "";
			}
		}

		private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveNotes(notes);
		}

		private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Form_Main_Load(object sender, EventArgs e)
		{
			notes = GetAllNotes();

			/*foreach (var note in notes)
			{
				flowLayoutPanel.Controls.Add(note);
				note.Click += SelectNote;
			}*/
		}

		private List<User> GetUsers()
		{
			SQLiteConnection con = new SQLiteConnection(connectionString);
			con.Open();
			List<User> users = new List<User>();
			using (SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"SELECT login FROM Users";
					SQLiteDataReader r = command.ExecuteReader();

					while (r.Read())
					{
						User newUser = new User()
						{
							login = r["login"].ToString(),
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
			tip.SetToolTip(button_AddUser, "Add user");
			tip.SetToolTip(button_RemoveUser, "Delete user");
			tip.SetToolTip(button_DeleteNote, "Delete note");
			tip.SetToolTip(button_AddNote, "Add note");
		}

		private void СomboBox_User_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (((sender as ComboBox).SelectedItem as User).login == currentUser.login)
				return;
			flowLayoutPanel.Controls.Clear();
			currentUser = (sender as ComboBox).SelectedItem as User;
			List<Note> notesForUser = GetNotesForUser(currentUser);
			foreach (Note note in notesForUser)
			{
				flowLayoutPanel.Controls.Add(note);
			}
		}
	}

	public class User
	{
		public string login { get; set; }
		public List<Note> notes = new List<Note>();

		public User()
		{

		}
	}
}