using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.Control;

namespace Notes
{
	/* Examlpe
	public static <Type of return value> <Extension method name>(this <Type of element that exteds> input)
	{
		<Method code>
	}
	*/
	public static class Extensions
	{
		public static void InsertInBeginning(this ControlCollection controlCollection, Control control)
		{
			controlCollection.Add(control);
			controlCollection.SetChildIndex(control, 0);
		}
	}
}
