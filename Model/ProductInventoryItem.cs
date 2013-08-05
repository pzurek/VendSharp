using System;

namespace Vend
{
	/// <summary>
	/// Product inventory item.
	/// </summary>
	public class ProductInventoryItem
	{
		/// <summary>
		/// Gets or sets the outlet identifier.
		/// </summary>
		/// <value>The outlet identifier.</value>
		public string OutletId { get; set; }

		/// <summary>
		/// Gets or sets the name of the outlet.
		/// </summary>
		/// <value>The name of the outlet.</value>
		public string OutletName { get; set; }

		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		/// <value>The count.</value>
		public int Count { get; set; }

		/// <summary>
		/// Gets or sets the reorder point.
		/// </summary>
		/// <value>The reorder point.</value>
		public int ReorderPoint { get; set; }

		/// <summary>
		/// Gets or sets the restock level.
		/// </summary>
		/// <value>The restock level.</value>
		public int RestockLevel { get; set; }
	}
}
