namespace Notes
{
	using System;
	using System.Data.SQLite;
	using System.Drawing;
	using System.Windows.Forms;

	public partial class Note: UserControl
	{
		public bool IsNew = true;
		public User Owner { get; set; }
		public int Rowid = 0;
		public DateTime DateOfCreation = new DateTime();
		private RichTextBox _RTB_Note = new RichTextBox();
		public RichTextBox RTB_Note
		{
			get { return _RTB_Note; }
			set
			{
				_RTB_Note = value;
				Text = _RTB_Note.Text;
			}
		}

		public string RTF
		{
			get
			{
				Text = RTB_Note.Text;
				return RTB_Note.Rtf;
			}

			set
			{
				RichTextBox temp = new RichTextBox
				{
					Rtf = value
				};
				RTB_Note = temp;
				Text = RTB_Note.Text;
			}
		}

		private string _Text;
		new public string Text
		{
			get { return _Text; }
			set
			{
				_Text = value;
				try
				{
					if(_RTB_Note.Lines.Length > 1)
						lbl_Content.Text = _RTB_Note.Lines[1];
				}
				catch { }

				try
				{
					if(_RTB_Note.Lines.Length != 0)
						lbl_Header.Text = _RTB_Note.Lines[0];
					else
					{
						lbl_Header.Text = "Empty note";
						lbl_Content.Text = "";
					}
				}
				catch { }
			}
		}

		public Note()
		{
			InitializeComponent();
			DateOfCreation = DateTime.Now;
		}

		Color tempColorClick;
		Color tempColorMove;

		private void Note_MouseEnter(object sender, EventArgs e)
		{
			tempColorMove = BackColor;
			BackColor = Color.FromArgb(223, 74, 22);
		}

		private void Note_MouseLeave(object sender, EventArgs e)
		{
			BackColor = tempColorMove;
		}

		private void Note_MouseDown(object sender, MouseEventArgs e)
		{
			tempColorClick = BackColor;
			tempColorMove = BackColor;
			BackColor = Color.FromArgb(224, 114, 76);
		}

		private void Note_MouseUp(object sender, MouseEventArgs e)
		{
			BackColor = tempColorClick;
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Do you want to delete this note?", "Deleting confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
				return;
			string strCon = "Data Source =  Notes.db; Version = 3";
			SQLiteConnection con = new SQLiteConnection(strCon);
			if(con.State == System.Data.ConnectionState.Closed)
				con.Open();

			using(SQLiteCommand command = con.CreateCommand())
			{
				try
				{
					command.CommandText = $"DELETE from Notes WHERE rowid = '{Rowid}'";
					command.ExecuteNonQuery();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			con.Close();
			Dispose();
		}
	}
}
