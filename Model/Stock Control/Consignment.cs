using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Consignment.
	/// </summary>
	/// <remarks>Based on 0.x API payload.</remarks>
	public class Consignment : BaseApiObject
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("consignment_date")]
		public string ConsignmentDate { get; set; }

		[JsonProperty("due_at")]
		public string DueAt { get; set; }

		[JsonProperty("received_at")]
		public string ReceivedAt { get; set; }

		[JsonProperty("retailer_id")]
		public string RetailerId { get; set; }

		[JsonProperty("outlet_id")]
		public string OutletId { get; set; }

		[JsonProperty("supplier_id")]
		public string SupplierId { get; set; }

		[JsonProperty("source_outlet_id")]
		public string SourceOutletId { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("accounts_transaction_id")]
		public string AccountsTransactionId { get; set; }
	}
}
