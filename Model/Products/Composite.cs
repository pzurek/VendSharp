using Newtonsoft.Json;

namespace Vend
{
	public class Composite : BaseApiObject
	{
		[JsonProperty("handle")]
		public string Handle { get; set; }

		[JsonProperty("sku")]
		public string Sku { get; set; }

		[JsonProperty("count")]
		public string Count { get; set; }
	}
}
