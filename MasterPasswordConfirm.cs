using System;
using System.Windows.Forms;

namespace Notes
{
	public partial class MasterPasswordConfirm : Form
	{

		public MasterPasswordConfirm()
		{
			InitializeComponent();
		}

		private void Button_Apply_Click(object sender, EventArgs e)
		{
			if (textBox_MasterPassword.Text == Main.masterPassword)
			{
				DialogResult = DialogResult.OK;
			}
			else
			{
				DialogResult = DialogResult.Cancel;
			}
		}

		private void Button_Deny_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
