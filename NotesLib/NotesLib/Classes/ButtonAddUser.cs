using NotesLib.Properties;
using System;
using System.Collections.Generic;
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
            BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            BackgroundImage = Resources.PlusSign;
            BackgroundImageLayout = ImageLayout.Zoom;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            FlatStyle = FlatStyle.Flat;
            Name = "buttonAddUser";
            Size = new System.Drawing.Size(273, 58);
            UseVisualStyleBackColor = false;
            Click += new EventHandler(this.buttonAddUser_Click);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserPanel newUser = new AddUserPanel();
            Parent.Controls.Add(newUser);
            Parent.Controls.SetChildIndex(Parent.Controls[Parent.Controls.Count - 1], 0); //Put last UserControl in begin
            ((Button)sender).Dispose();
        }
    }
}
