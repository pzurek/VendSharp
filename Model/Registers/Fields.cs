using Newtonsoft.Json;

namespace Vend
{
	public class Fields
	{
		[JsonProperty("label_invoice")]
		public string LabelInvoice { get; set; }

		[JsonProperty("label_invoice_title")]
		public string LabelInvoiceTitle { get; set; }

		[JsonProperty("label_served_by")]
		public string LabelServedBy { get; set; }

		[JsonProperty("label_line_discount")]
		public string LabelLineDiscount { get; set; }

		[JsonProperty("label_sub_total")]
		public string LabelSubTotal { get; set; }

		[JsonProperty("label_tax")]
		public string LabelTax { get; set; }

		[JsonProperty("label_to_pay")]
		public string LabelToPay { get; set; }

		[JsonProperty("label_total")]
		public string LabelTotal { get; set; }

		[JsonProperty("label_change")]
		public string LabelChange { get; set; }

		[JsonProperty("header")]
		public string Header { get; set; }

		[JsonProperty("footer")]
		public string Footer { get; set; }
	}
}
