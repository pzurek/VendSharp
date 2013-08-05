using System;

namespace Vend
{
	/// <summary>
	/// Product type.
	/// </summary>
	public class ProductType : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the retailer identifier.
		/// </summary>
		/// <value>The retailer identifier.</value>
		public string RetailerId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
	}
}
