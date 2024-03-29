﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notes
{
	public class TextBoxWithPlaceholder : TextBox
	{
		public string Placeholder { get; set; }

		public TextBoxWithPlaceholder()
		{
			ForeColor = Color.Gray;
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			if(Text.Equals(string.Empty))
				Text = Placeholder;
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);

			if(Text.Equals(string.Empty))
			{
				Text = Placeholder;
				ForeColor = Color.Gray;
			}
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);

			if(Text.Equals(Placeholder))
			{
				Text = string.Empty;
				ForeColor = Color.FromName("ControlLight");
			}
		}
	}
}
