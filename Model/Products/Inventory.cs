using Newtonsoft.Json;

namespace Vend
{
	public class Inventory
	{
		[JsonProperty("outlet_id")]
		public string OutletId { get; set; }

		[JsonProperty("outlet_name")]
		public string OutletName { get; set; }

		[JsonProperty("count")]
		public string Count { get; set; } // TODO: should be an int

		[JsonProperty("reorder_point")]
		public string ReorderPoint { get; set; } // TODO: should be an int

		[JsonProperty("restock_level")]
		public string RestockLevel { get; set; } // TODO: should be an int
	}
}
