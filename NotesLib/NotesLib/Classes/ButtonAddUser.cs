using NotesLib.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesLib
{
	public class ButtonAddUser : Button
	{
		public ButtonAddUser()
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

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserPanel newUser = new AddUserPanel();
            Parent.Controls.Add(newUser);
            Parent.Controls.SetChildIndex(Parent.Controls[Parent.Controls.Count - 1], 0); //Put last UserControl in beginning
            ((Button)sender).Dispose();
        }
    }
}
