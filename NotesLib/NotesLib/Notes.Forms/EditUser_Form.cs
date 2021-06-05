using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesLib;

namespace Notes.Forms
{
	public partial class EditUser_Form : Form
	{
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
				textBoxLogin.Text = _user_Panel.User.Login;
				textBoxDescription.Text = _user_Panel.User.Description;
				pictureBoxUserAvatar.Image = _user_Panel.User.Image;
			}
		}

		public EditUser_Form()
		{
			InitializeComponent();
		}
	}
}
