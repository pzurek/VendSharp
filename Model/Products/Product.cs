using System.Collections.Generic;

namespace Vend
{
	public class Product : BaseApiObject
	{
		public string SourceId { get; set; }

		public string VariantSourceId { get; set; }

		public string Handle { get; set; }

		public string Type { get; set; }

		public string VariantParentId { get; set; }

		public string VariantOptionOneName { get; set; }

		public string VariantOptionOneValue { get; set; }

		public string VariantOptionTwoName { get; set; }

		public string VariantOptionTwoValue { get; set; }

		public string VariantOptionThreeName { get; set; }

		public string VariantOptionThreeValue { get; set; }

		public bool Active { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string Image { get; set; }

		public string ImageLarge { get; set; }

		public string Sku { get; set; }

		public string Tags { get; set; }

		public string BrandId { get; set; }

		public string BrandName { get; set; }

		public string SupplierName { get; set; }

		public string SupplierCode { get; set; }

		public string SupplyPrice { get; set; }

		public string AccountCodePurchase { get; set; }

		public string AccountCodeSales { get; set; }

		public List<Composite> Composites { get; set; }

		public List<PricebookEntry> PricebookEntries { get; set; }

		// Not used for selling. Not sure for what exactly it is
		// but the Sell screen takes it from the pricebook
		public double Price { get; set; }

		public double Tax { get; set; }

		public string TaxId { get; set; }

		public double TaxRate { get; set; }

		public string TaxName { get; set; }

		public int DisplayRetailPriceTaxInclusive { get; set; }

		public string UpdatedAt { get; set; }

		public string DeletedAt { get; set; }

		public List<Inventory> Inventory { get; set; }
	}
}
