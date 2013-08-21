using System.Collections.Generic;

namespace Vend
{
	/// <summary>
	/// Global store config object.
	/// </summary>
	public class Config
	{
		public string RetailerId { get; set; }
		public string RetailerName { get; set; }
		public string AccountState { get; set; }
		public string DomainPrefix { get; set; }
		public string DisplayRetailPriceTaxInclusive { get; set; }
		public string UserId { get; set; }
		public string UserName { get; set; }
		public string UserHash { get; set; }
		public string UserDisplayName { get; set; }
		public bool NotifyUserOfNumpad { get; set; }
		public string AccountType { get; set; }
		public string OutletName { get; set; }
		public string OutletId { get; set; }
		public string Version { get; set; }
		public List<MigrateSql> MigrateSql { get; set; }
		public string LastSync { get; set; }
		public string CurrencyName { get; set; }
		public string Currency { get; set; }
		public string Culture { get; set; }
		public string DefaultCustomerGroupId { get; set; }
		public string DefaultCustomerId { get; set; }
		public string DiscountProductId { get; set; }
		public bool CashierDiscount { get; set; }
		public int EnableLoyalty { get; set; }
		public Callbacks Callbacks { get; set; }
	}
}
