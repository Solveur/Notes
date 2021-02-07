using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Notes
{
	public partial class DeleteUser : Form
	{
		string connectionString = "Data Source =  Notes.db; Version = 3";
		public string login;
		public DeleteUser()
		{
			InitializeComponent();
		}

		private void DeleteUser_Load(object sender, EventArgs e)
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
			if (checkBox1.Checked != false)
			{
				login = comboBox_login.Text;
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
						fmd.CommandText = $"DELETE FROM Users WHERE login = '{login}'";

						fmd.ExecuteNonQuery();
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
		}

		private void Button_Deny_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void DeleteUser_FormClosed(object sender, FormClosedEventArgs e)
		{
			comboBox_login.Text = "";
			comboBox_login.Items.Clear();
		}
	}
}
