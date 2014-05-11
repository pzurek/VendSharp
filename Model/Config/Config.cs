using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Global store config object.
	/// </summary>
	public class Config
	{
		[JsonProperty("retailer_id")]
		public string RetailerId { get; set; }

		[JsonProperty("retailer_name")]
		public string RetailerName { get; set; }

		[JsonProperty("account_state")]
		public string AccountState { get; set; }

		[JsonProperty("domain_prefix")]
		public string DomainPrefix { get; set; }

		[JsonProperty("display_retail_price_tax_inclusive")]
		public string DisplayRetailPriceTaxInclusive { get; set; }

		[JsonProperty("user_id")]
		public string UserId { get; set; }

		[JsonProperty("user_name")]
		public string UserName { get; set; }

		[JsonProperty("user_hash")]
		public string UserHash { get; set; }

		[JsonProperty("user_display_name")]
		public string UserDisplayName { get; set; }

		[JsonProperty("notify_useer_of_numpad")]
		public bool NotifyUserOfNumpad { get; set; }

		[JsonProperty("account_type")]
		public string AccountType { get; set; }

		[JsonProperty("outlet_name")]
		public string OutletName { get; set; }

		[JsonProperty("outlet_id")]
		public string OutletId { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("migrate_sql")]
		public List<MigrateSql> MigrateSql { get; set; }

		[JsonProperty("last_sync")]
		public string LastSync { get; set; }

		[JsonProperty("currency_name")]
		public string CurrencyName { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("culture")]
		public string Culture { get; set; }

		[JsonProperty("default_customer_group_id")]
		public string DefaultCustomerGroupId { get; set; }

		[JsonProperty("default_customer_id")]
		public string DefaultCustomerId { get; set; }

		[JsonProperty("discount_product_id")]
		public string DiscountProductId { get; set; }

		[JsonProperty("cashier_discount")]
		public bool CashierDiscount { get; set; }

		[JsonProperty("enable_loyalty")]
		public int EnableLoyalty { get; set; }

		[JsonProperty("callbacks")]
		public Callbacks Callbacks { get; set; }
	}
}
