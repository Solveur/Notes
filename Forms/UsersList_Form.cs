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
using Notes.Properties;

namespace Notes.Forms
{
	public partial class UsersList_Form : Form
	{
	 	public List<UserPanel> usersPanel = new List<UserPanel>();
		public List<User> users = new List<User>();
		public UsersList_Form()
		{
			InitializeComponent();
			usersFlowPanel.Controls.Add(new ButtonAddUser());
		}

		private void buttonAddUser_Click(object sender, EventArgs e)
		{
			((Button)sender).Hide();
			AddUserPanel newUser = new AddUserPanel();
			usersFlowPanel.Controls.Add(newUser);
		}
	}
}
