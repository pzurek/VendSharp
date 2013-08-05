using System;

namespace Vend
{
	/// <summary>
	/// Product inventory item.
	/// </summary>
	public class ProductInventoryItem : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the product identifier.
		/// </summary>
		/// <value>The product identifier.</value>
		public string ProductId { get; set; }

		/// <summary>
		/// Gets or sets the outlet identifier.
		/// </summary>
		/// <value>The outlet identifier.</value>
		public string OutletId { get; set; }

		/// <summary>
		/// Gets or sets the attributed cost.
		/// </summary>
		/// <value>The attributed cost.</value>
		public float AttributedCost { get; set; }

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
