namespace Vend
{
	public class PricebookEntry : BaseApiObject
	{
		public string ProductId { get; set; }

		public string PriceBookId { get; set; }

		public string PriceBookName { get; set; }

		public string Type { get; set; }

		public string OutletName { get; set; }

		public string OutletId { get; set; }

		public string CustomerGroupName { get; set; }

		public string CustomerGroupId { get; set; }

		public double Price { get; set; }

		public double LoyaltyValue { get; set; }

		public double Tax { get; set; }

		public string TaxId { get; set; }

		public string TaxRate { get; set; }

		public string TaxName { get; set; }

		public int DisplayRetailPriceTaxInclusive { get; set; }

		public string MinUnits { get; set; }

		public string MaxUnits { get; set; }

		public string ValidFrom { get; set; }

		public string ValidTo { get; set; }
	}
}
