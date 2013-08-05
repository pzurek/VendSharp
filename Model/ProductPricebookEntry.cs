using System;

namespace Vend
{
	/// <summary>
	/// Product pricebook entry.
	/// </summary>
	public class ProductPricebookEntry : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the product identifier.
		/// </summary>
		/// <value>The product identifier.</value>
		public string ProductId { get; set; }

		/// <summary>
		/// Gets or sets the pricebook identifier.
		/// </summary>
		/// <value>The pricebook identifier.</value>
		public string PricebookId { get; set; }

		/// <summary>
		/// Gets or sets the name of the pricebook.
		/// </summary>
		/// <value>The name of the pricebook.</value>
		public string PricebookName { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the name of the outlet.
		/// </summary>
		/// <value>The name of the outlet.</value>
		public string OutletName { get; set; }

		/// <summary>
		/// Gets or sets the outlet identifier.
		/// </summary>
		/// <value>The outlet identifier.</value>
		public string OutletId { get; set;}

		/// <summary>
		/// Gets or sets the name of the customer gounp.
		/// </summary>
		/// <value>The name of the customer gounp.</value>
		public string CustomerGounpName { get; set; }

		/// <summary>
		/// Gets or sets the customer group identifier.
		/// </summary>
		/// <value>The customer group identifier.</value>
		public string CustomerGroupId { get; set; }

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>The price.</value>
		public float Price { get; set; }

		/// <summary>
		/// Gets or sets the loyalty value.
		/// </summary>
		/// <value>The loyalty value.</value>
		public float LoyaltyValue { get; set; }

		/// <summary>
		/// Gets or sets the tax.
		/// </summary>
		/// <value>The tax value.</value>
		public float Tax { get; set; }

		/// <summary>
		/// Gets or sets the tax identifier.
		/// </summary>
		/// <value>The tax identifier.</value>
		public string TaxId { get; set; }

		/// <summary>
		/// Gets or sets the tax rate.
		/// </summary>
		/// <value>The tax rate.</value>
		public float TaxRate { get; set; }

		/// <summary>
		/// Gets or sets the name of the tax.
		/// </summary>
		/// <value>The name of the tax.</value>
		public string TaxName { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.ProductPricebookEntry"/> displays retail price tax inclusive.
		/// </summary>
		/// <value><c>true</c> if display retail price tax inclusive; otherwise, <c>false</c>.</value>
		public bool DisplayRetailPriceTaxInclusive { get; set; }

		/// <summary>
		/// Gets or sets the max units.
		/// </summary>
		/// <value>The max units.</value>
		public int MaxUnits { get; set; }

		/// <summary>
		/// Gets or sets the minimum units.
		/// </summary>
		/// <value>The minimum units.</value>
		public int MinUnits { get; set; }

		/// <summary>
		/// Gets or sets the valid from.
		/// </summary>
		/// <value>The valid from.</value>
		public DateTime ValidFrom { get; set; }

		/// <summary>
		/// Gets or sets the valid to.
		/// </summary>
		/// <value>The valid to.</value>
		public DateTime ValidTo { get; set; }
	}
}

