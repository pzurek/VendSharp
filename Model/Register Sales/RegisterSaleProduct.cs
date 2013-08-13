using System.Collections.Generic;

namespace Vend
{
	/// <summary>
	/// Register sale product.
	/// </summary>
	/// <remarks>Created based on 0.x API payload</remarks>
	public class RegisterSaleProduct : BaseApiObject
	{
		public string ProductId { get; set; }

		public string RegisterId { get; set; }

		public string Sequence { get; set; }

		public string Handle { get; set; }

		public string Sku { get; set; }

		public string Name { get; set; }

		public int Quantity { get; set; }

		public double Price { get; set; }

		public int PriceSet { get; set; }

		public int Discount { get; set; }

		public double LoyaltyValue { get; set; }

		public double Tax { get; set; }

		public string TaxId { get; set; }

		public double TaxRate { get; set; }

		public double TaxTotal { get; set; }

		public double PriceTotal { get; set; }

		public string DisplayRetailPriceTaxInclusive { get; set; }

		public string Status { get; set; }

		public List<Attribute> Attributes { get; set; }
	}
}
