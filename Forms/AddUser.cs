using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Notes
{
	public partial class AddUser : Form
	{
		public string login;

		public AddUser()
		{
			InitializeComponent();
		}

		private void Button_Apply_Click(object sender, EventArgs e)
		{
			if (new MasterPasswordConfirm().ShowDialog() == DialogResult.OK)
			{
				login = textBox_login.Text;
				AddUserToDB(login);
			}
			else
			{
				MessageBox.Show("Master password doesn't match");
				return;
			}
			ClearForm();
		}

		private void Button_Deny_Click(object sender, EventArgs e)
		{
			ClearForm();
			Close();
		}

		void AddUserToDB(string login)
		{
			string connectionString = "Data Source =  Notes.db; Version = 3";
			SQLiteConnection con;
			con = new SQLiteConnection(connectionString);
			if(con.State == System.Data.ConnectionState.Closed)
				con.Open();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"INSERT INTO users (login) VALUES ('{login}')";

					fmd.ExecuteNonQuery();
					MessageBox.Show("NEW USER ADDED SUCCESSFULLY TO SQLITE DB!", "SUCCES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DialogResult = DialogResult.OK;
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		void ClearForm()
		{
			login = "";
			textBox_login.Text = "";
			comboBox_Rights.SelectedItem = null;
		}
	}
}
