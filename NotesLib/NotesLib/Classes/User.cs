using System.Collections.Generic;
using System.Drawing;

namespace NotesLib
{
	public class User
	{
		public string login { get; set; } = string.Empty;
		public string description { get; set; } = string.Empty;
		public Image image { get; set; } = null;
		public List<Note> notes = new List<Note>();

		public User()
		{

		}
	}
}
