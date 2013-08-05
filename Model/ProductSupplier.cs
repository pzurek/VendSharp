using System;

namespace Vend
{
	/// <summary>
	/// Product supplier - apparently a different class then the general supplier.
	/// </summary>
	public class ProductSupplier : BaseApiObject
	{
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
		/// Gets or sets the source.
		/// </summary>
		/// <value>The source.</value>
		public string Source { get; set; }
	}
}

