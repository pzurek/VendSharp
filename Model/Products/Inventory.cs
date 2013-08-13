namespace Vend
{
	public class Inventory
	{
		public string OutletId { get; set; }

		public string OutletName { get; set; }

		public string Count { get; set; } // TODO: should be an int

		public string ReorderPoint { get; set; } // TODO: should be an int

		public string RestockLevel { get; set; } // TODO: should be an int
	}
}
