using System;

using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Register.
	/// </summary>
	public class Register : BaseApiObject
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("outlet_id")]
		public string OutletId { get; set; }

		[JsonProperty("print_receipt")]
		public string PrintRecept { get; set; }

		[JsonProperty("email_receipt")]
		public string EmailReceipt { get; set; }

		[JsonProperty("ask_for_note_on_save")]
		public string AskForNoteOnSave { get; set; }

		[JsonProperty("print_note_on_receipt")]
		public string PrintNoteOnReceipt { get; set; }

		[JsonProperty("ask_for_user_on_sale")]
		public string AskForUserOnSale { get; set; }

		[JsonProperty("show_discounts_on_receipt")]
		public string ShowDiscountsOnReceipt { get; set; }

		[JsonProperty("receipt_header")]
		public string ReceiptHeader { get; set; }

		[JsonProperty("receipt_barcoded")]
		public string ReceiptBarcoded { get; set; }

		[JsonProperty("receipt_footer")]
		public string ReceiptFooter { get; set; }

		[JsonProperty("receipt_style_class")]
		public string ReceiptStyleClass { get; set; }

		[JsonProperty("invoice_prefix")]
		public string InvoicePrefix { get; set; }

		[JsonProperty("invoice_suffix")]
		public string InvoiceSuffix { get; set; }

		[JsonProperty("invoice_sequence")]
		public int InvoiceSequence { get; set; }

		[JsonProperty("register_open_count_sequence")]
		public string RegisterOpenCountSequence { get; set; }

		[JsonProperty("register_open_time")]
		public string RegisterOpenTime { get; set; }

		[JsonProperty("register_close_time")]
		public string CloseTime { get; set; }

		[JsonProperty("quick_keys_template")]
		public QuickKeysTemplate QuickKeysTemplate { get; set; }

		[JsonProperty("receipt")]
		public Receipt Receipt { get; set; }

	}
}
