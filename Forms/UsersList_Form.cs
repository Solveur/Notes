using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes.Forms
{

	public partial class UsersList_Form : Form
	{
		public UsersList_Form()
		{
			InitializeComponent();
			users_FlowPanel.Controls.Add(new ButtonAddUser());
		}

		private List<User> _users = new List<User>();
		public List<User> Users
		{
			get
			{
				return _users;
			}
			set
			{
				_users = value;
				users_FlowPanel.Controls.Clear();
				users_FlowPanel.Controls.Add(new ButtonAddUser());
				foreach(User user in _users)
				{
					User_Panel newUserPanel = new User_Panel
					{
						User = user
					};
					users_FlowPanel.Controls.Add(newUserPanel);
				}
			}
		}

		public void UpdateList()
		{
			Users.Clear();
			foreach(var User_Panel in users_FlowPanel.Controls)
			{
				if(User_Panel.GetType() == new User_Panel().GetType())
				{
					Users.Add(((User_Panel)User_Panel).User);
				}
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void menuStrip_MouseDown(object sender, MouseEventArgs e)
		{
			Capture = false;
			Message message = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
			WndProc(ref message);
		}

		private void UsersList_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			UpdateList();
		}
	}
}
