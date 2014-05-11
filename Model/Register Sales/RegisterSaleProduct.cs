using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Register sale product.
	/// </summary>
	/// <remarks>Created based on 0.x API payload</remarks>
	public class RegisterSaleProduct : BaseApiObject
	{
		[JsonProperty("product_id")]
		public string ProductId { get; set; }

		[JsonProperty("register_id")]
		public string RegisterId { get; set; }

		[JsonProperty("sequence")]
		public string Sequence { get; set; }

		[JsonProperty("handle")]
		public string Handle { get; set; }

		[JsonProperty("sku")]
		public string Sku { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("price_set")]
		public int PriceSet { get; set; }

		[JsonProperty("discount")]
		public int Discount { get; set; }

		[JsonProperty("loyalty_value")]
		public double LoyaltyValue { get; set; }

		[JsonProperty("tax")]
		public double Tax { get; set; }

		[JsonProperty("tax_id")]
		public string TaxId { get; set; }

		[JsonProperty("tax_rate")]
		public double TaxRate { get; set; }

		[JsonProperty("tax_total")]
		public double TaxTotal { get; set; }

		[JsonProperty("price_total")]
		public double PriceTotal { get; set; }

		[JsonProperty("display_retail_price_tax_inclusive")]
		public string DisplayRetailPriceTaxInclusive { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("attributes")]
		public List<Attribute> Attributes { get; set; }
	}
}
