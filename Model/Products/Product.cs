using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class Product : BaseApiObject
	{
		[JsonProperty("source_id")]
		public string SourceId { get; set; }

		[JsonProperty("variant_source_id")]
		public string VariantSourceId { get; set; }

		[JsonProperty("handle")]
		public string Handle { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("variant_parent_id")]
		public string VariantParentId { get; set; }

		[JsonProperty("variant_option_one_name")]
		public string VariantOptionOneName { get; set; }

		[JsonProperty("variant_option_one_value")]
		public string VariantOptionOneValue { get; set; }

		[JsonProperty("variant_option_two_name")]
		public string VariantOptionTwoName { get; set; }

		[JsonProperty("variant_option_two_value")]
		public string VariantOptionTwoValue { get; set; }

		[JsonProperty("variant_option_three_name")]
		public string VariantOptionThreeName { get; set; }

		[JsonProperty("variant_option_three_value")]
		public string VariantOptionThreeValue { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("image_large")]
		public string ImageLarge { get; set; }

		[JsonProperty("sku")]
		public string Sku { get; set; }

		[JsonProperty("tags")]
		public string Tags { get; set; }

		[JsonProperty("brand_id")]
		public string BrandId { get; set; }

		[JsonProperty("brand_name")]
		public string BrandName { get; set; }

		[JsonProperty("supplier_name")]
		public string SupplierName { get; set; }

		[JsonProperty("supplier_code")]
		public string SupplierCode { get; set; }

		[JsonProperty("supply_price")]
		public string SupplyPrice { get; set; }

		[JsonProperty("account_code_purchase")]
		public string AccountCodePurchase { get; set; }

		[JsonProperty("account_code_sales")]
		public string AccountCodeSales { get; set; }

		[JsonProperty("composites")]
		public List<Composite> Composites { get; set; }

		[JsonProperty("price_book_entries")]
		public List<PriceBookEntry> PriceBookEntries { get; set; }

		// Not used for selling. Not sure for what exactly it is
		// but the Sell screen takes it from the pricebook
		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("tax")]
		public double Tax { get; set; }

		[JsonProperty("tax_id")]
		public string TaxId { get; set; }

		[JsonProperty("tax_rate")]
		public double TaxRate { get; set; }

		[JsonProperty("tax_name")]
		public string TaxName { get; set; }

		[JsonProperty("display_retail_price_inclusive")]
		public int DisplayRetailPriceTaxInclusive { get; set; }

		[JsonProperty("updated_at")]
		public string UpdatedAt { get; set; }

		[JsonProperty("deleted_at")]
		public string DeletedAt { get; set; }

		[JsonProperty("inventory")]
		public List<Inventory> Inventory { get; set; }
	}
}
