using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notes.Forms;

namespace NotesLib
{
	public partial class User_Panel : UserControl
	{
		private User _user = new User();
		public User User
		{
			get 
			{
				return _user;
			}
			set
			{
				_user = value;
				if (_user.Image != null)
					UserAvatar.Image = _user.Image;
				else
					UserAvatar.Image = Properties.Resources.NoImage;
				labelUserLogin.Text = _user.Login;
				textBoxDescription.Text = _user.Description;
			}
		}

		public User_Panel()
		{
			InitializeComponent();
		}

		private void pictureBox_MouseEnter(object sender, EventArgs e)
		{
			((PictureBox)sender).BackColor = Color.DarkGray;
		}

		private void pictureBox_MouseLeave(object sender, EventArgs e)
		{
			((PictureBox)sender).BackColor = Color.Transparent;
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog fileDialog = new OpenFileDialog())
			{
				fileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg|ico files(*.ico)|*.ico|all files(*.*)|*.*";
				if (fileDialog.ShowDialog() != DialogResult.OK)
					return;
				((PictureBox)sender).Image = Image.FromFile(fileDialog.FileName);
				User.Image = Image.FromFile(fileDialog.FileName);
			}
		}

		private void buttonEditUser_Click(object sender, EventArgs e)
		{
			User_Panel user_Panel = ((Button)sender).Parent as User_Panel;
			using(EditUser_Form user_Editor = new EditUser_Form())
			{
				user_Editor.User_Panel = user_Panel;
				user_Editor.ShowDialog();
			}
		}
	}
}
