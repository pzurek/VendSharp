using Newtonsoft.Json;

namespace Vend
{
	public class PriceBookEntry : BaseApiObject
	{
		[JsonProperty("product_id")]
		public string ProductId { get; set; }

		[JsonProperty("price_book_id")]
		public string PriceBookId { get; set; }

		[JsonProperty("price_book_name")]
		public string PriceBookName { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("outlet_name")]
		public string OutletName { get; set; }

		[JsonProperty("outlet_id")]
		public string OutletId { get; set; }

		[JsonProperty("customer_group_name")]
		public string CustomerGroupName { get; set; }

		[JsonProperty("customer_group_id")]
		public string CustomerGroupId { get; set; }

		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("loyalty_value")]
		public double LoyaltyValue { get; set; }

		[JsonProperty("tax")]
		public double Tax { get; set; }

		[JsonProperty("tax_id")]
		public string TaxId { get; set; }

		[JsonProperty("tax_rate")]
		public string TaxRate { get; set; }

		[JsonProperty("tax_name")]
		public string TaxName { get; set; }

		[JsonProperty("display_retail_price_tax_inclusive")]
		public int DisplayRetailPriceTaxInclusive { get; set; }

		[JsonProperty("min_units")]
		public string MinUnits { get; set; }

		[JsonProperty("max_units")]
		public string MaxUnits { get; set; }

		[JsonProperty("valid_from")]
		public string ValidFrom { get; set; }

		[JsonProperty("valid_to")]
		public string ValidTo { get; set; }
	}
}
