namespace Notes
{
	using System.Collections.Generic;
	using System.Drawing;

	public class User
	{
		public bool IsNew = true;
		public int Rowid { get; set; } = 0;
		public string Login { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public Image Avatar { get; set; } = null;
		public List<Note> Notes = new List<Note>();

		public User() { }
	}
}
