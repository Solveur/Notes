using System;
using System.Data.SQLite;
using System.Windows.Forms;
using NotesLib;

namespace Notes
{
	public partial class AddUser : Form
	{
		public User newUser = new User();

		public AddUser()
		{
			InitializeComponent();
		}

		private void Button_Apply_Click(object sender, EventArgs e)
		{
			newUser.login = textBox_login.Text;
			AddUserToDB(newUser);
			ClearForm();
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
			if(con.State == System.Data.ConnectionState.Closed)
				con.Open();
			using (SQLiteCommand fmd = con.CreateCommand())
			{
				try
				{
					fmd.CommandText = $"INSERT INTO users (login) VALUES ('{user.login}')";
					fmd.ExecuteNonQuery();
					MessageBox.Show("NEW USER ADDED SUCCESSFULLY TO SQLITE DB!", "SUCCES!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DialogResult = DialogResult.OK;
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("SQLITE SELECT ERROR: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		void ClearForm()
		{
			textBox_login.Text = "";
		}
	}
}
