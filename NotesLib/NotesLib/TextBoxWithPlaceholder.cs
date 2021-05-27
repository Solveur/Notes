using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotesLib
{
	public class TextBoxWithPlaceholder : TextBox
	{
		private string _Placeholder { get; set; }
		public string Placeholder
		{
			get
			{
				return _Placeholder;
			}

			set
			{
				_Placeholder = value;
				Text = value;
			}
		}

		public TextBoxWithPlaceholder()
        {
			ForeColor = Color.Gray;
        }

		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			if (!DesignMode)
				Text = Placeholder;
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);

			if (Text.Equals(string.Empty))
			{
				Text = Placeholder;
				ForeColor = Color.Gray;
			}
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);

			if (Text.Equals(Placeholder))
			{
				Text = string.Empty;
				ForeColor = Color.FromName("WindowText");
			}
		}
	}
}
