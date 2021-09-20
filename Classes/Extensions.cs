namespace Notes
{
	using System.Windows.Forms;

	using static System.Windows.Forms.Control;

	/* Examlpe
  public static <Type of return value> <Extension method name>(this <Type of element that exteds> input)
  {
      <Method code>
  }
  */
	public static class Extentions
  {
    public static void InsertInBeginning(this ControlCollection controlCollection, Control control)
    {
      controlCollection.Add(control);
      controlCollection.SetChildIndex(control, 0);
    }
  }
}
