using System.Drawing;
using System.Windows.Forms;

namespace Notes
{
	internal class MenuStripRenderer: ProfessionalColorTable
	{
		Color dropdownMenuItemSelected = Color.FromArgb(223, 74, 22);
		Color menuBorder = Color.FromArgb(52, 52, 52);
		Color menuItemBorder = Color.FromArgb(52, 52, 52);
		Color menuItemSelected = Color.FromArgb(223, 74, 22);
		Color menuItemPressed = Color.FromArgb(223, 74, 22);
		Color toolStripDropDownBackground = Color.FromArgb(52, 52, 52);
		Color imageMarginGradientBegin = Color.FromArgb(52, 52, 52);

		public MenuStripRenderer()
		{

		}

		public override Color MenuItemSelected
		{
			get { return dropdownMenuItemSelected; }
		}

		public override Color MenuBorder
		{
			get { return menuBorder; }
		}

		public override Color MenuItemBorder
		{
			get { return menuItemBorder; }
		}

		public override Color MenuItemSelectedGradientBegin
		{
			get { return menuItemSelected; }
		}

		public override Color MenuItemSelectedGradientEnd
		{
			get { return menuItemSelected; }
		}

		public override Color MenuItemPressedGradientBegin
		{
			get { return menuItemPressed; }
		}

		public override Color MenuItemPressedGradientEnd
		{
			get { return menuItemPressed; }
		}

		public override Color ToolStripDropDownBackground
		{
			get { return toolStripDropDownBackground; }
		}

		public override Color ImageMarginGradientBegin
		{
			get { return imageMarginGradientBegin; }
		}

		public override Color ImageMarginGradientEnd
		{
			get { return imageMarginGradientBegin; }
		}
	}
}
