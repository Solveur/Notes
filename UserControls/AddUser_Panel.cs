namespace Notes
{
	using System;
	using System.Data;
	using System.Data.SQLite;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.IO;
	using System.Windows.Forms;

	public partial class AddUser_Panel: UserControl
	{
		public User user = new User();
		private User_Panel userPanel = new User_Panel();
		private static string strCon = "Data Source =  Notes.db; Version = 3";
		private SQLiteConnection con = new SQLiteConnection(strCon);

		public AddUser_Panel()
		{
			InitializeComponent();
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			using(OpenFileDialog fileDialog = new OpenFileDialog())
			{
				fileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg|ico files(*.ico)|*.ico|all files(*.*)|*.*";
				if(fileDialog.ShowDialog() != DialogResult.OK)
					return;
				((PictureBox)sender).Image = Image.FromFile(fileDialog.FileName);
			}
		}

		// TODO: Максимальный rowid не сохраняется, новые создаются с 0
		private void buttonApply_Click(object sender, EventArgs e)
		{
			user.Login = textBoxLogin.Text;
			user.Description = textBoxDescription.Text;
			user.Image = pictureBoxUserAvatar.Image;
			user.IsNew = false;
			user.Rowid = GetMaxRowid() + 1;

			userPanel.User = user;
			SaveUserToDB(user);

			Parent.Controls.InsertInBeginning(userPanel);
			Parent.Controls.InsertInBeginning(new ButtonAddUser());
			Dispose();
		}

		void SaveUserToDB(User user)
		{
			if(con.State == ConnectionState.Closed)
				con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				command.Parameters.AddWithValue("@login", user.Login);
				command.Parameters.AddWithValue("@description", user.Description);
				command.Parameters.AddWithValue("@avatar", ImageToByte(user.Image, user.Image.RawFormat));
				command.CommandText = "INSERT INTO Users(login, description, avatar) VALUES(@login, @description, @avatar)";

				try
				{
					command.ExecuteNonQuery();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
		}

		int GetMaxRowid()
		{
			int maxRowid = new int();
			if(con.State == ConnectionState.Closed)
				con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				command.CommandText = "SELECT rowid FROM Users ORDER BY rowid DESC";

				try
				{
					SQLiteDataReader r = command.ExecuteReader();
					if(r.Read())
						maxRowid = Convert.ToInt32(r["rowid"]);
					r.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
			return maxRowid;
		}

		private byte[] ImageToByte(Image image, ImageFormat format)
		{
			using(MemoryStream ms = new MemoryStream())
			{
				// Convert Image to byte[]
				image.Save(ms, format);
				byte[] imageBytes = ms.ToArray();
				return imageBytes;
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Parent.Controls.InsertInBeginning(new ButtonAddUser());
			Dispose();
		}

		private void pictureBox_MouseEnter(object sender, EventArgs e)
		{
			((PictureBox)sender).BackColor = Color.DarkGray;
		}

		private void pictureBox_MouseLeave(object sender, EventArgs e)
		{
			((PictureBox)sender).BackColor = Color.Transparent;
		}

		private void buttonCancel_MouseEnter(object sender, EventArgs e)
		{
			((Button)sender).ForeColor = Color.FromName("WindowText");
		}

		private void buttonCancel_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).ForeColor = Color.FromName("ControlLight");
		}

		private void buttonApply_MouseEnter(object sender, EventArgs e)
		{
			((Button)sender).ForeColor = Color.FromName("WindowText");
		}

		private void buttonApply_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).ForeColor = Color.FromName("ControlLight");
		}
	}
}
