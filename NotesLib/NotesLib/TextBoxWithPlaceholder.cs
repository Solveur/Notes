using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotesLib
{
	public class TextBoxWithPlaceholder : TextBox
	{
		private Color foreColorTemp;
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
				foreColorTemp = ForeColor;
				ForeColor = Color.Gray;
			}
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);

			if (Text.Equals(Placeholder))
			{
				Text = string.Empty;
				ForeColor = foreColorTemp;
			}
		}
	}
}
