using Newtonsoft.Json;

namespace Vend
{
	public class RegisterSalePayment : BaseApiObject
	{
		[JsonProperty("payment_type_id")]
		public string PaymentTypeId { get; set; }

		[JsonProperty("register_id")]
		public string RegisterId { get; set; }

		[JsonProperty("retailer_payment_type_id")]
		public string RetailerPaymentTypeId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("payment_date")]
		public string PaymentDate { get; set; }

		[JsonProperty("amount")]
		public double Amount { get; set; }
	}
}
