using System;
using System.Windows.Forms;

namespace NotesLib
{
    public partial class Note : UserControl
	{
		public RichTextBox RTB_Note = new RichTextBox();
		public string login = "";
		public int rowid = 0;
		public DateTime dateOfCreation = new DateTime();

		public void SetHeader(RichTextBox rtb)
		{
			try
			{
				if (rtb.Lines.Length != 0)
					lbl_Header.Text = rtb.Lines[0];
				else
				{
					lbl_Header.Text = "Empty note";
					lbl_Content.Text = "";
				}
			}
			catch { }
		}

		public void SetContent(RichTextBox rtb)
		{
			try
			{
				if(rtb.Lines.Length > 1)
					lbl_Content.Text = rtb.Lines[1];
			}
			catch
			{

			}
		}

		public Note(EventHandler SelectNote)
		{
			InitializeComponent();
			Click += SelectNote;
			lbl_Header.Click += SelectNote;
			lbl_Content.Click += SelectNote;
		}
	}
}
