using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Notes
{
    public partial class AddUser : Form
    {
        public string login;
        public string password;
        public User.Rights rights;
        public string masterPassword { get; set; }

        public AddUser(User.Rights rights)
        {
            InitializeComponent();
            this.rights = rights;
        }

        private void TextBox_Rights_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '0' && e.KeyChar != 8) e.Handled = true;
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && rights == 0)
            {
                MasterPasswordConfirm confirm = new MasterPasswordConfirm();
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    if (textBox_password.Text == textBox_ConfirmPassword.Text)
                    {
                        login = textBox_login.Text;
                        password = textBox_password.Text;
                        string connectionString = "Data Source =  Notes.db; Version = 3";
                        SQLiteConnection con;
                        con = new SQLiteConnection(connectionString);
                        try
                        {
                            con.Open();
                        }
                        catch
                        {
                        }
                        using (SQLiteCommand fmd = con.CreateCommand())
                        {
                            try
                            {
                                fmd.CommandText = $"INSERT INTO users (login, password, rights) VALUES ('{login}','{password}','{Convert.ToInt32(checkBox1.Checked)}')";

                                fmd.ExecuteNonQuery();
                                MessageBox.Show("NEW USER ADDED SUCCESSFULLY TO SQLITE DB!", "SUCCES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DialogResult = DialogResult.OK;
                                textBox_login.Text = "";
                                textBox_password.Text = "";
                                checkBox1.Checked = false;
                                Close();
                                return;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords doesn't match");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Master password doesn't match");
                    return;
                }
            }
            if (textBox_password.Text == textBox_ConfirmPassword.Text)
            {
                login = textBox_login.Text;
                password = textBox_password.Text;
                string connectionString = "Data Source =  Notes.db; Version = 3";
                SQLiteConnection con;
                con = new SQLiteConnection(connectionString);
                try
                {
                    con.Open();
                }
                catch
                {
                }
                using (SQLiteCommand fmd = con.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = $"INSERT INTO users (login, password, rights) VALUES ('{login}','{password}','{Convert.ToInt32(checkBox1.Checked)}')";

                        fmd.ExecuteNonQuery();
                        MessageBox.Show("NEW USER ADDED SUCCESSFULLY TO SQLITE DB!", "SUCCES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        textBox_login.Text = "";
                        textBox_password.Text = "";
                        checkBox1.Checked = false;
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords doesn't match");
            }
        }

        private void CheckBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked == true)
            {
                textBox_password.PasswordChar = '\0';
                textBox_ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '●';
                textBox_ConfirmPassword.PasswordChar = '●';
            }
            textBox_password.Focus();
        }

        private void Button_Deny_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
