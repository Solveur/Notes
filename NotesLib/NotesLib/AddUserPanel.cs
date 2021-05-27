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
    public partial class AddUserPanel : UserControl
    {
        public string login { get; set; } = string.Empty;
        string description { get; set; } = string.Empty;
		Image image { get; set; }
        public AddUserPanel()
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
				image = Image.FromFile(fileDialog.FileName);
			}
		}

        private void buttonApply_Click(object sender, EventArgs e)
		{
			User user = new User()
			{
				login = textBoxLogin.Text,
				description = textBoxDescription.Text,
				image = image
			};
			UserPanel userPanel = new UserPanel()
			{
				user = user
			};
			Parent.Controls.Add(userPanel);
			Parent.Controls.SetChildIndex(Parent.Controls[Parent.Controls.Count - 1], 0); //Put userPanel in beginning
			Parent.Controls.Add(new ButtonAddUser());
			Parent.Controls.SetChildIndex(Parent.Controls[Parent.Controls.Count - 1], 0); //Shifts userPanel to second place and puts ButtonAddUser in beginnig
			Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
			Parent.Controls.Add(new ButtonAddUser());
			Parent.Controls.SetChildIndex(Parent.Controls[Parent.Controls.Count - 1], 0);
			Dispose();
		}
	}
}
