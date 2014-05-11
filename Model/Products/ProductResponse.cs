using Newtonsoft.Json;

namespace Vend
{
	public class ProductResponse
	{
		[JsonProperty("product")]
		public Product Product { get; set; }
	}
}
