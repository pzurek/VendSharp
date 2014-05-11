using Newtonsoft.Json;

namespace Vend
{
	public class Key
	{
		[JsonProperty("position")]
		public int Position { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("sku")]
		public string Sku { get; set; }

		[JsonProperty("product_id")]
		public string ProductId { get; set; }

		[JsonProperty("color")]
		public string Color { get; set; }

		[JsonProperty("parent")]
		public bool Parent { get; set; }
	}
}
