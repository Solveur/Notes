using System;
using System.Windows.Forms;

using NotesLib;

namespace Notes.Forms
{
	public partial class EditUser_Form: Form
	{
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
				pictureBoxUserAvatar.Image = newUser.Image;
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
			newUser.Image = pictureBoxUserAvatar.Image;
			User_Panel.User = newUser;
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Dispose();
			Close();
		}

		private void EditUser_Form_MouseDown(object sender, MouseEventArgs e)
		{
			Capture = false;
			Message message = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
			WndProc(ref message);
		}

		private void pictureBoxUserAvatar_Click(object sender, EventArgs e)
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
