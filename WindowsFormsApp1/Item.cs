using System.Collections.Generic;

namespace WindowsFormsApp1
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public bool Notifications { get; set; }
		public List<ItemState> States { get; set; }
	}
}
