using System;

namespace Vend
{
	/// <summary>
	/// Pricebook entry.
	/// </summary>
	public class PricebookEntry : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the product identifier.
		/// </summary>
		/// <value>The product identifier.</value>
		public string ProductId { get; set; }

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
		/// Gets or sets the price.
		/// </summary>
		/// <value>The price.</value>
		public float Price { get; set; }

		/// <summary>
		/// Gets or sets the tax.
		/// </summary>
		/// <value>The tax.</value>
		public float TaxValue { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the customer group identifier.
		/// </summary>
		/// <value>The customer group identifier.</value>
		public string CustomerGroupId { get; set; }

		/// <summary>
		/// Gets or sets the name of the customer gounp.
		/// </summary>
		/// <value>The name of the customer gounp.</value>
		public string CustomerGounpName { get; set; }

		/// <summary>
		/// Gets or sets the tax identifier.
		/// </summary>
		/// <value>The tax identifier.</value>
		public string TaxId { get; set; }

		/// <summary>
		/// Gets or sets the tax.
		/// </summary>
		/// <value>The tax.</value>
		public Tax Tax { get; set; }
	}
}

