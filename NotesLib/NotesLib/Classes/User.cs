using System.Collections.Generic;
using System.Drawing;

namespace NotesLib
{
	public class User
	{
		public int Rowid { get; set; } = 0;
		public string Login { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public Image Image { get; set; } = null;
		public List<Note> notes = new List<Note>();

		public User()
		{

		}
	}
}
