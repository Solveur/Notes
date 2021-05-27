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
    public partial class UsersList_Form : Form
    {
        public UsersList_Form()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            User user = new User();
        }
    }
}
