using System;
using System.Collections.Generic;

namespace Vend
{
	/// <summary>
	/// An item for sale.
	/// </summary>
	public class Product : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the retailer identifier.
		/// </summary>
		/// <value>The retailer identifier.</value>
		public string RetailerId { get; set; }

		/// <summary>
		/// Gets or sets the sku.
		/// </summary>
		/// <value>The sku.</value>
		public string Sku { get; set; }

		/// <summary>
		/// Gets or sets the handle.
		/// </summary>
		/// <value>The handle.</value>
		public string Handle { get; set; }

		/// <summary>
		/// Gets or sets the source.
		/// </summary>
		/// <value>The source.</value>
		public string Source { get; set; }

		/// <summary>
		/// Gets or sets the source identifier.
		/// </summary>
		/// <value>The source identifier.</value>
		public string SourceId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Product"/> is active.
		/// </summary>
		/// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
		public bool Active { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public ProductType Type { get; set; }

		/// <summary>
		/// Gets or sets the supplier.
		/// </summary>
		/// <value>The supplier.</value>
		public ProductSupplier Supplier { get; set; }

		/// <summary>
		/// Gets or sets the brand.
		/// </summary>
		/// <value>The brand.</value>
		public ProductBrand Brand { get; set; }

		/// <summary>
		/// Gets or sets the inventory.
		/// </summary>
		/// <value>The inventory.</value>
		public List<ProductInventoryItem> Inventory { get; set; }

		/// <summary>
		/// Gets or sets the pricebook entries.
		/// </summary>
		/// <value>The pricebook entries.</value>
		public List<PricebookEntry> PricebookEntries { get; set; }
	}
}
