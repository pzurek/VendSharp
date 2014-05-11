using Newtonsoft.Json;

namespace Vend
{
	public class ProductType : BaseApiObject
	{
		[JsonProperty("retailer_id")]
		public string RetailerId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
