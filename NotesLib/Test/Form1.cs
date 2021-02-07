using System;
using System.Windows.Forms;
using NotesLib;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            note1.Text = "1";
            note2.Text = "2";
        }
        void SelectNote(object sender, EventArgs e)
        {
            if(sender is Note aa)
            {
                richTextBox1.Text = aa.Text;
            }
        }
    }
}
