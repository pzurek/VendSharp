using Newtonsoft.Json;

namespace Vend
{
	public class PaymentConfig
	{
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
