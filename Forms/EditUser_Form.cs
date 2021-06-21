namespace Notes
{
	using Notes.Forms;
	using System;
	using System.Data;
	using System.Data.SQLite;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.IO;
	using System.Windows.Forms;

	public partial class EditUser_Form : Form
	{
		private static string strCon = "Data Source = Notes.db; Version = 3";
		private SQLiteConnection con = new SQLiteConnection(strCon);
		private User newUser = new User();
		private User_Panel _user_Panel = new User_Panel();
		public User_Panel User_Panel
		{
			get
			{
				return _user_Panel;
			}
			set
			{
				_user_Panel = value;
				newUser = _user_Panel.User;
				textBoxLogin.Text = newUser.Login;
				textBoxDescription.Text = newUser.Description;
				pictureBoxUserAvatar.Image = newUser.Avatar;
			}
		}

		public EditUser_Form()
		{
			InitializeComponent();
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			newUser.Login = textBoxLogin.Text;
			newUser.Description = textBoxDescription.Text;
			newUser.Avatar = pictureBoxUserAvatar.Image;
			User_Panel.User = newUser;

			UpdateUserInDB(User_Panel.User);
			Close();
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			UsersList_Form parent = (UsersList_Form)Owner;
			Main_Form main = (Main_Form)parent.Owner;

			DeleteUserFromDB(User_Panel.User);
			User_Panel.Dispose();
			main.SetCurrentUser(null);
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}


		private void DeleteUserFromDB(User user)
		{
			con = new SQLiteConnection(strCon);
			if(con.State == ConnectionState.Closed)
				con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				command.Parameters.AddWithValue("@rowid", user.Rowid);
				command.CommandText = "DELETE FROM Users WHERE id=@rowid";
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

		void UpdateUserInDB(User user)
		{
			if(con.State == ConnectionState.Closed)
				con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				command.Parameters.AddWithValue("@rowid", user.Rowid);
				command.Parameters.AddWithValue("@login", user.Login);
				command.Parameters.AddWithValue("@description", user.Description);
				command.Parameters.AddWithValue("@avatar", ImageToByte(user.Avatar, user.Avatar.RawFormat));
				command.CommandText = "UPDATE Users SET login=@login, description=@description, avatar=@avatar WHERE id=@rowid";

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

		private void EditUser_Form_MouseDown(object sender, MouseEventArgs e)
		{
			Capture = false;
			Message message = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
			WndProc(ref message);
		}

		private void pictureBoxUserAvatar_Click(object sender, EventArgs e)
		{
			using(OpenFileDialog fileDialog = new OpenFileDialog())
			{
				fileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg|ico files(*.ico)|*.ico|all files(*.*)|*.*";
				if(fileDialog.ShowDialog() != DialogResult.OK)
					return;
				((PictureBox)sender).Image = Image.FromFile(fileDialog.FileName);
			}
		}

		private void pictureBoxUserAvatar_MouseEnter(object sender, EventArgs e)
		{
			((PictureBox)sender).BackColor = Color.DarkGray;
		}

		private void pictureBoxUserAvatar_MouseLeave(object sender, EventArgs e)
		{
			((PictureBox)sender).BackColor = Color.Transparent;
		}
	}
}
