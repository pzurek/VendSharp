namespace Vend
{
	/// <summary>
	/// Consignment.
	/// </summary>
	/// <remarks>Based on 0.x API payload.</remarks>
	public class Consignment : BaseApiObject
	{
		public string Name { get; set; }

		public string ConsignmentDate { get; set; }

		public string DueAt { get; set; }

		public string ReceivedAt { get; set; }

		public string RetailerId { get; set; }

		public string OutletId { get; set; }

		public string SupplierId { get; set; }

		public string SourceOutletId { get; set; }

		public string Status { get; set; }

		public string Type { get; set; }

		public string AccountsTransactionId { get; set; }
	}
}
