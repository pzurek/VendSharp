using Newtonsoft.Json;

namespace Vend
{
	public class PaymentType : BaseApiObject
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("payment_type_id")]
		public string PaymentTypeId { get; set; }

		[JsonProperty("config")]
		public PaymentConfig Config { get; set; }

		[JsonProperty("payment_type_2")]
		public PaymentType2 PaymentType2 { get; set; }
	}
}
