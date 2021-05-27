using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using NotesLib;

namespace Notes
{
    public partial class DeleteUser_Form : Form
    {
        private string connectionString = "Data Source =  Notes.db; Version = 3";
        public User user;

        public DeleteUser_Form()
        {
            InitializeComponent();
        }

        private void DeleteUser_Form_Load(object sender, EventArgs e)
        {
            comboBox_login.DataSource = GetUsers();
            comboBox_login.DisplayMember = "login";
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                return;
            user = (User)comboBox_login.SelectedItem;
            DeleteUser(user);
        }

        private void Button_Deny_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteUser(User user)
        {
            if (checkBox1.Checked == false)
                return;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            if (con.State != ConnectionState.Open)
                con.Open();
            using (SQLiteCommand command = con.CreateCommand())
            {
                try
                {
                    command.CommandText = $"DELETE FROM Users WHERE login = '{user.login}'";
                    command.ExecuteNonQuery();

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    DialogResult = DialogResult.No;
                    Close();
                }
            }
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
    }
}