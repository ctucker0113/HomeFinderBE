using System;
namespace HomeFinderBE.Models
{
	public class Item
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public string? Image { get; set; }
		public int RoomID { get; set; }
	}
}

