using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Notes
{
	public partial class Login : Form
	{
		public string connectionString = "Data Source =  Notes.db; Version = 3";
		public string login;
		public string password;
		public int rights = -1;
		public Login()
		{
			InitializeComponent();
		}

		private void Button_Deny_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			SQLiteConnection con;
			con = new SQLiteConnection(connectionString);
			con.Open();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				fmd.CommandText = @"SELECT login FROM Users";
				SQLiteDataReader r = fmd.ExecuteReader();
				while (r.Read())
				{
					comboBox_login.Items.Add(r["login"].ToString());
				}
				r.Close();
				con.Close();
			}
		}

		private void Button_Apply_Click(object sender, EventArgs e)
		{
			login = comboBox_login.Text;
			password = textBox_password.Text;
			SQLiteConnection con = new SQLiteConnection(connectionString);
			try
			{
				con.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("SQLITE CONNECT ERROR : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"SELECT rights FROM Users WHERE login = '{login}' AND password = '{password}'";

					SQLiteDataReader r = fmd.ExecuteReader();
					while (r.Read())
					{
						rights = Convert.ToInt32(r["rights"]);
					}
					r.Close();

					if (rights != -1)
					{
						using (var form = new Main())
						{
							form.login = login;
							form.password = password;
							form.rights = rights;
							Hide();
							form.ShowDialog();
						}
					}

					else
					{
						MessageBox.Show("ERROR! Invalid user or password!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch
				{
					login = "";
					password = "";
				}
			}
		}

		private void Button_AddUser_Click(object sender, EventArgs e)
		{
			AddUser add = new AddUser(0);
			Hide();
			add.ShowDialog();
			try
			{
				comboBox_login.Items.Add(add.login);
			}
			catch
			{

			}
			Update();
			Show();
		}

		private void CheckBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_ShowPassword.Checked == true)
			{
				textBox_password.PasswordChar = '\0';
			}
			else
			{
				textBox_password.PasswordChar = '●';
			}
			textBox_password.Focus();
		}
	}
}

