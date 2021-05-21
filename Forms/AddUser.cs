using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Notes
{
	public partial class AddUser : Form
	{
		User user = new User();

		public AddUser()
		{
			InitializeComponent();
		}

		private void Button_Apply_Click(object sender, EventArgs e)
		{
			user.login = textBox_login.Text;
			AddUserToDB(user);
		}

		private void Button_Deny_Click(object sender, EventArgs e)
		{
			Close();
		}

		void AddUserToDB(User user)
		{
			string connectionString = "Data Source =  Notes.db; Version = 3";
			SQLiteConnection con;
			con = new SQLiteConnection(connectionString);
			if(con.State != ConnectionState.Open)
				con.Open();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				fmd.CommandText = $"INSERT INTO users (login, password, rights) VALUES ('{user.login}')";
				fmd.ExecuteNonQuery();
				MessageBox.Show("NEW USER ADDED SUCCESSFULLY TO SQLITE DB!", "SUCCES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
				return;
			}
		}
	}
}
