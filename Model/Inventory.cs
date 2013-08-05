using System;

namespace Vend
{
	/// <summary>
	/// Inventory records record the stock of a <see cref="Vend.Product"/> at a single <see cref="Vend.Outlet"/>. They also keep track of other stock-keeping values, such as the attributed cost of a product.
	/// </summary>
	public class Inventory : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the inventory item.
		/// </summary>
		/// <value>The inventory item.</value>
		public ProductInventoryItem InventoryItem { get; set; }

		/// <summary>
		/// Gets or sets the product.
		/// </summary>
		/// <value>The product.</value>
		public Product Product { get; set; }
	}
}
