using System;
using System.Drawing;
using System.Windows.Forms;
using NotesLib.Properties;

namespace NotesLib
{

	public class ButtonAddUser : Button
	{
		public ButtonAddUser()
		{
			Design();
		}

		private void buttonAddUser_Click(object sender, EventArgs e)
		{
			AddUser_Panel newUser_Panel = new AddUser_Panel();
			User newUser = new User();

			newUser_Panel.user = newUser;
			Parent.Controls.Add(newUser_Panel);
			Parent.Controls.SetChildIndex(Parent.Controls[Parent.Controls.Count - 1], 0); // Put last UserControl in beginning
			((Button)sender).Dispose();
		}

		void Design()
		{
			BackColor = Color.Transparent;
			BackgroundImage = Resources.PlusSign;
			BackgroundImageLayout = ImageLayout.Zoom;
			FlatAppearance.BorderSize = 0;
			FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 114, 76);
			FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 73, 73);
			FlatStyle = FlatStyle.Flat;
			Size = new Size(273, 58);
			Click += new EventHandler(buttonAddUser_Click);
		}
	}
}
