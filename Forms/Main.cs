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

		public List<Note> notes = new List<Note>();
		public Note selectedNote = null;

		//TODO: Change user select
		public List<User> users = new List<User>();
		public User currentUser = new User();
		//some change


		public Main()
		{
			InitializeComponent();
			users = GetUsers();
			UpdateComboBox();
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
				login = currentUser.login,
				dateOfCreation = DateTime.Now
			};
			note.Click += new EventHandler(SelectNote);
			notes.Add(note);
			notesFlowPanel.Controls.Add(note);
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

			try
			{
				notes.Remove(selectedNote);
				notesFlowPanel.Controls.Remove(selectedNote);
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

		private void СomboBox_User_SelectionChangeCommitted(object sender, EventArgs e)
		{
			User newUser = (sender as ComboBox).SelectedItem as User;
			if (newUser.login == currentUser.login)
				return;
			notesFlowPanel.Controls.Clear();
			currentUser = newUser;
			List<Note> notesForUser = GetNotesForUser(currentUser);
			AddNotesToFlowPanel(notesForUser);
		}

		private void Button_AddUser_Click(object sender, EventArgs e)
		{
			AddUser();
		}

		private void Button_DeleteUser_Click(object sender, EventArgs e)
		{
			DeleteUser();
		}

		private void Form_Main_Load(object sender, EventArgs e)
		{
			notes = GetAllNotes();
		}

		private void AddNotesToFlowPanel(List<Note> notes)
		{
			foreach (var note in notes)
			{
				notesFlowPanel.Controls.Add(note);
				note.Click += SelectNote;
			}
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveNotes(notes);
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
				catch (Exception ex) 
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
		}

		private List<Note> GetNotesForUser(User user)
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

		private List<Note> GetAllNotes()
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
							dateOfCreation = Convert.ToDateTime(r["dateOfCreate"].ToString())
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
			tip.SetToolTip(button_DeleteUser, "Delete user");
			tip.SetToolTip(button_DeleteNote, "Delete note");
			tip.SetToolTip(button_AddNote, "Add note");
		}

		void AddUser()
		{
			using (AddUser addUser = new AddUser())
			{
				addUser.ShowDialog();
				users = GetUsers();
				UpdateComboBox();
			};
		}

		void DeleteUser()
		{
			using (DeleteUser_Form deleteUser = new DeleteUser_Form())
			{
				deleteUser.ShowDialog();
				if (deleteUser.user != currentUser)
					return;
				richTextBox_NoteText.Text = "";
				comboBox_User.Text = "";
			}
		}

		void UpdateComboBox()
		{
			comboBox_User.DataSource = null;
			comboBox_User.DataSource = users;
			comboBox_User.DisplayMember = "login";
			comboBox_User.SelectedItem = null;
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