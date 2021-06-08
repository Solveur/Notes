using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace NotesLib
{
	public partial class AddUser_Panel: UserControl
	{
		public User user = new User();
		User_Panel userPanel = new User_Panel();

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

		private void buttonApply_Click(object sender, EventArgs e)
		{
			user.Login = textBoxLogin.Text;
			user.Description = textBoxDescription.Text;
			user.Image = pictureBoxUserAvatar.Image;

			userPanel.User = user;

			Parent.Controls.InsertInBeginning(userPanel);
			Parent.Controls.InsertInBeginning(new ButtonAddUser());
			Dispose();
		}

		void GetUsers()
		{
			List<User> users = new List<User>();
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
