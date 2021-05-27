using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesLib
{
	public partial class UserPanel : UserControl
	{
		Color tempBackColor;
		private User _user = new User();
		public User user
        {
            get 
			{
				return _user;
			}

			set
            {
				_user = value;
				if (_user.image != null)
					UserAvatar.Image = _user.image;
				else
					UserAvatar.Image = Properties.Resources.NoImage;
				labelUserLogin.Text = _user.login;
				textBoxDecription.Text = _user.description;
            }
        }
		public UserPanel()
		{
			InitializeComponent();
		}

		private void pictureBox_MouseEnter(object sender, EventArgs e)
		{
			tempBackColor = ((PictureBox)sender).BackColor;
			((PictureBox)sender).BackColor = Color.DarkGray;
		}

		private void pictureBox_MouseLeave(object sender, EventArgs e)
		{
			((PictureBox)sender).BackColor = tempBackColor;
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog fileDialog = new OpenFileDialog())
			{
				fileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg|ico files(*.ico)|*.ico|all files(*.*)|*.*";
				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					((PictureBox)sender).Image = Image.FromFile(fileDialog.FileName);
					user.image = Image.FromFile(fileDialog.FileName);
				}
			}
		}
	}
}
