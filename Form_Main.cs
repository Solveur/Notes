using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using NotesLib;

namespace Курсач
{
	public partial class Form_Main : Form
	{

		public string connectionString = "Data Source =  Notes.db; Version = 3";    //DB variables
		public List<Note> notes = new List<Note>();                                 //
		public List<Note> deletedNotes = new List<Note>();                          //

		public Note selectedNote = null;    //Current note

		Login log = new Login();                //Login variables
		DeleteUser delete = new DeleteUser();   //
		public string login { get; set; }       //
		public string password { get; set; }    //
		public int rights { get; set; }         //


		public static string masterPassword = "1234";   //Master password for creating admin accounts
		public Form_Main()
		{
			InitializeComponent();
			if (selectedNote == null)                   //Hide textBox
			{                                           //
				richTextBox_NoteText.Visible = false;   //
			}                                           //

			//Add tooltips to Form_main buttons
			ToolTip tip = new ToolTip();
			tip.SetToolTip(button_ChangeUser, "Change user");
			tip.SetToolTip(button_AddUser, "Add user");
			tip.SetToolTip(button_RemoveUser, "Delete user");
			tip.SetToolTip(button_DeleteNote, "Delete note");
			tip.SetToolTip(button_AddNote, "Add note");
		}

		public void SelectNote(object sender, EventArgs e)
		{
			if (sender is Note note)                                        //If click on Note background
			{                                                               //		
				if (selectedNote != null)                                   //
				{                                                           //
					selectedNote.BorderStyle = BorderStyle.FixedSingle;     //
				}                                                           //
				selectedNote = note;                                        //
				selectedNote.BorderStyle = BorderStyle.Fixed3D;             //
				richTextBox_NoteText.Visible = true;                        //
				richTextBox_NoteText.Text = note.Text;                      //
				richTextBox_NoteText.Focus();                               //
			}                                                               //

			else if (sender is Label label)                                 //If click on Label
			{                                                               //
				if (selectedNote != null)                                   //
				{                                                           //
					selectedNote.BorderStyle = BorderStyle.FixedSingle;     //
				}                                                           //
				selectedNote = label.Parent as Note;                        //
				selectedNote.BorderStyle = BorderStyle.Fixed3D;             //
				richTextBox_NoteText.Visible = true;                        //
				richTextBox_NoteText.Text = (label.Parent as Note).Text;    //
				richTextBox_NoteText.Focus();                               //
			}
		}

		private void Button_AddNote_Click(object sender, EventArgs e)
		{
			Note note = new Note(SelectNote);       //Create new Note
			note.dateOfCreation = DateTime.Now;     //Add date of creation
			notes.Add(note);                        //Add Note to the List 
			flowLayoutPanel1.Controls.Add(note);    //Add Note to the user interface
		}

		private void Button_DeleteNote_Click(object sender, EventArgs e)
		{
			try
			{
				Note n = notes[0];
			}
			catch
			{
				MessageBox.Show("There is no notes");
				return;
			}
			if (MessageBox.Show("Do you want to delete this note?", "Deleting confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				SQLiteConnection con;                           //Open DB connection
				con = new SQLiteConnection(connectionString);   //
				con.Open();                                     //

				using (SQLiteCommand fmd = con.CreateCommand())                                         //Delete note from DB
				{                                                                                       //
					try                                                                                 //
					{                                                                                   //
						fmd.CommandText = $"DELETE from Notes WHERE rowid = '{selectedNote.rowid}'";    //
						fmd.ExecuteNonQuery();                                                          //
					}                                                                                   //
					catch (Exception ex)                                                                //
					{                                                                                   //
						MessageBox.Show(ex.ToString());                                                 //
					}                                                                                   //
				}                                                                                       //
				con.Close();                                                                            //

				deletedNotes.Add(selectedNote); //Add Note to the deleted List

				try
				{
					notes.Remove(selectedNote);                     //Delete note from RAM
					flowLayoutPanel1.Controls.Remove(selectedNote); //
					SelectNote(notes[0], e);                        //
				}
				catch
				{
					richTextBox_NoteText.Visible = false;
				}
			}
			else
			{

			}
		}

		private void RichTextBox_NoteText_TextChanged(object sender, EventArgs e)
		{
			try
			{
				selectedNote.Text = richTextBox_NoteText.Text;  //Copy text from TextBox to Note's internal memory
				selectedNote.SetHeader(richTextBox_NoteText);   //
				selectedNote.SetContent(richTextBox_NoteText);  //
			}
			catch
			{

			}
		}

		public void DB_AddAllNotes(string login)    //Add all notes to DB
		{
			SQLiteConnection con = new SQLiteConnection(connectionString);  //Open DB connection
			con.Open();                                                     //

			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					foreach (var note in notes) //For all notes in List (RAM)
					{
						if (note.rowid == 0)                                                                                                                    //If Note does'n exist, create
						{                                                                                                                                       //
							fmd.CommandText = $"INSERT INTO Notes(login, note, dateOfCreate) VALUES('{login}', '{note.Text}', '{note.dateOfCreation:yyyy-MM-dd hh:mm:ss}')";    //
							fmd.ExecuteNonQuery();                                                                                                              //
						}                                                                                                                                       //

						else                                                                                            //If Note exist, update
						{                                                                                               //
							fmd.CommandText = $"UPDATE Notes SET note = '{note.Text}' WHERE rowid = '{note.rowid}'";    //
							fmd.ExecuteNonQuery();                                                                      //
						}                                                                                               //
					}
				}
				catch
				{

				}
			}
			con.Close();
		}

		public void DB_ReadAllNotes(string login)   //Read all notes from DB
		{
			SQLiteConnection con = new SQLiteConnection(connectionString);  //Open DB connection
			con.Open();                                                     //

			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"SELECT note, rowid, dateOfCreate FROM Notes WHERE login = '{login}'";
					SQLiteDataReader r = fmd.ExecuteReader();
					while (r.Read())
					{
						Note note = new Note(SelectNote)
						{
							Text = r["note"].ToString(),
							rowid = Convert.ToInt32(r["rowid"]),
							dateOfCreation = Convert.ToDateTime(r["dateOfCreate"])
						};
						richTextBox_NoteText.Text = note.Text;
						note.SetHeader(richTextBox_NoteText);
						note.SetContent(richTextBox_NoteText);
						notes.Add(note);
					}
					r.Close();
					richTextBox_NoteText.Text = "";
					fmd.ExecuteNonQuery();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
		}

		private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			DB_AddAllNotes(login);
		}

		private void Form_Main_Load(object sender, EventArgs e)
		{
			DB_ReadAllNotes(login);
			foreach (var note in notes)
			{
				flowLayoutPanel1.Controls.Add(note);
			}
			label_User.Text = login;
		}

		private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Button_AddUser_Click(object sender, EventArgs e)
		{
			AddUser add = new AddUser(rights);
			add.ShowDialog();
		}

		private void Button_RemoveUser_Click(object sender, EventArgs e)
		{
			if (rights == 1)
			{
				delete.ShowDialog();
				if (delete.login == login)
				{
					Hide();
					log.ShowDialog();
				}
			}
			else MessageBox.Show("Error! You don't have permission to do this", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void Button_ChangeUser_Click(object sender, EventArgs e)
		{
			Visible = false;
			log.Show();
		}
	}
}
