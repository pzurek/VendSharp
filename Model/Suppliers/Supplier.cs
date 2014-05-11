using Newtonsoft.Json;

namespace Vend
{
	public class Supplier : BaseApiObject
	{
		[JsonProperty("retailer_id")]
		public string RetailerId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("source")]
		public string Source { get; set; }

		[JsonProperty("contact")]
		public Contact Contact { get; set; }
	}
}
