using NotesLib;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Main : Form
    {
        public string connectionString = "Data Source =  Notes.db; Version = 3";    //DB variables
        public List<Note> notes = new List<Note>();
        public List<Note> deletedNotes = new List<Note>();

        public Note selectedNote = null;    //Current note

        //TODO: Change user select
        public User user = new User()
        {
            rights = User.Rights.GuestRigths
        };

        DeleteUser formDelete = new DeleteUser();

        public static string masterPassword = "1234";   //Master password for creating admin accounts
        public Main()
        {
            InitializeComponent();
            LoadUsers();
            SetTooltips();
            if(selectedNote == null)  //Hide textBox
            {
                richTextBox_NoteText.Visible = false;
            }
            comboBox_User.Text = "Guest";
        }

        public void SelectNote(object sender, EventArgs e)
        {
            //TODO: Polymorphism
            if(sender is Note note)                                        //If click on Note background
            {
                if(selectedNote != null)
                {
                    selectedNote.BorderStyle = BorderStyle.FixedSingle;
                }
                selectedNote = note;
                selectedNote.BorderStyle = BorderStyle.Fixed3D;
                richTextBox_NoteText.Visible = true;
                richTextBox_NoteText.Rtf = note.RTF;
                richTextBox_NoteText.Focus();
            }

            else if(sender is Label label)                                 //If click on Label
            {
                if(selectedNote != null)
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
                dateOfCreation = DateTime.Now       //Add date of creation
            };                                      //Create new Note
            note.Click += new EventHandler(SelectNote);
            notes.Add(note);                        //Add Note to the List 
            flowLayoutPanel.Controls.Add(note);     //Add Note to the user interface
        }

        private void Button_DeleteNote_Click(object sender, EventArgs e)
        {
            if(notes.Count > 0)
            {
                if(MessageBox.Show("Do you want to delete this note?", "Deleting confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                        flowLayoutPanel.Controls.Remove(selectedNote);  //
                        SelectNote(notes[0], e);                        //
                    }
                    catch
                    {
                        richTextBox_NoteText.Visible = false;
                    }
                }
            }
        }

        private void RichTextBox_NoteText_TextChanged(object sender, EventArgs e)
        {
            //TODO: RTF save
            if(selectedNote != null)
            {
                selectedNote.RTF = richTextBox_NoteText.Rtf;
            }
            //selectedNote.SetHeader(richTextBox_NoteText);
            //selectedNote.SetContent(richTextBox_NoteText);
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
                        if(note.rowid == 0)                                                                                                                    //If Note does'n exist, create
                        {                                                                                                                                       //
                            fmd.CommandText = $"INSERT INTO Notes(login, note, dateOfCreate) VALUES('{login}', '{note.RTF}', '{note.dateOfCreation:yyyy-MM-dd hh:mm:ss}')";    //
                            fmd.ExecuteNonQuery();                                                                                                              //
                        }                                                                                                                                       //

                        else                                                                                            //If Note exist, update
                        {                                                                                               //
                            fmd.CommandText = $"UPDATE Notes SET note = '{note.RTF}' WHERE rowid = '{note.rowid}'";    //
                            fmd.ExecuteNonQuery();                                                                      //
                        }                                                                                               //
                    }
                }
                catch { }
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
                        Note note = new Note()
                        {
                            RTF = r["note"].ToString(),
                            rowid = Convert.ToInt32(r["rowid"]),
                            dateOfCreation = Convert.ToDateTime(r["dateOfCreate"])
                        };
                        richTextBox_NoteText.Rtf = note.RTF;
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

        public async Task DB_ReadAllNotesAsync(string login)   //Read all notes from DB
        {
            await Task.Run(() => DB_ReadAllNotesAsync(login));
        }

        async void LoadAsync()
        {
            await DB_ReadAllNotesAsync(user.login);

            foreach (var note in notes)
            {
                flowLayoutPanel.Controls.Add(note);
            }
            comboBox_User.Text = user.login;
        }

        private void Button_RemoveUser_Click(object sender, EventArgs e)
        {
            if(user.rights == User.Rights.AdminRights)
            {
                formDelete.ShowDialog();
                if(formDelete.login == user.login)
                {
                    Hide();
                    richTextBox_NoteText.Text = "";
                    comboBox_User.Text = "";
                }
            }
            else MessageBox.Show("Error! You don't have permission to do this", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB_AddAllNotes(user.login);
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            DB_ReadAllNotes(user.login);

            foreach (var note in notes)
            {
                flowLayoutPanel.Controls.Add(note);
                note.Click += SelectNote;
            }
        }

        private void Button_AddUser_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser(user.rights);
            add.ShowDialog();
        }

        private void LoadUsers()
        {
            SQLiteConnection con = new SQLiteConnection(connectionString);  //Open DB connection
            con.Open();                                                     //

            using (SQLiteCommand command = con.CreateCommand())
            {
                try
                {
                    command.CommandText = $"SELECT login FROM Users";
                    SQLiteDataReader r = command.ExecuteReader();

                    while (r.Read())
                    {
                        comboBox_User.Items.Add(r["login"]);
                    }
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            con.Close();
        }

        void SetTooltips()
        {
            //Add tooltips to Form_main buttons
            ToolTip tip = new ToolTip();
            tip.SetToolTip(button_AddUser, "Add user");
            tip.SetToolTip(button_RemoveUser, "Delete user");
            tip.SetToolTip(button_DeleteNote, "Delete note");
            tip.SetToolTip(button_AddNote, "Add note");
        }

        private void comboBox_User_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        public string login { get; set; }
        public Rights rights;

        public enum Rights
        {
            AdminRights = 3,
            SpectatorRights = 2,
            UserRights = 1,
            GuestRigths = 0
        }
    }
}