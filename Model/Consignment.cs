using System;

namespace Vend
{
	/// <summary>
	/// Returns a single consignment by ID.
	/// </summary>
	public class Consignment : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the consignment date.
		/// </summary>
		/// <value>The consignment date.</value>
		public DateTime ConsignmentDate { get; set; }

		/// <summary>
		/// Gets or sets the due at.
		/// </summary>
		/// <value>The due at.</value>
		public DateTime DueAt { get; set; }

		/// <summary>
		/// Gets or sets the received at.
		/// </summary>
		/// <value>The received at.</value>
		public DateTime ReceivedAt { get; set; }

		/// <summary>
		/// Gets or sets the retailer identifier.
		/// </summary>
		/// <value>The retailer identifier.</value>
		public string RetailerId { get; set; }

		/// <summary>
		/// Gets or sets the outlet identifier.
		/// </summary>
		/// <value>The outlet identifier.</value>
		public string OutletId { get; set; }

		/// <summary>
		/// Gets or sets the supplier identifier.
		/// </summary>
		/// <value>The supplier identifier.</value>
		public string SupplierId { get; set; }

		/// <summary>
		/// Gets or sets the source outlet identifier.
		/// </summary>
		/// <value>The source outlet identifier.</value>
		public string SourceOutletId { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		/// <example>"OPEN"</example>
		public string Status { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		/// <example>"SUPPLIER"</example>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the accounts transaction identifier.
		/// </summary>
		/// <value>The accounts transaction identifier.</value>
		public string AccountsTransactionId { get; set; }
	}
}
