namespace Vend
{
	public class Consignment : BaseApiObject
	{
		public string Name { get; set; }

		public string ConsignmentDate { get; set; }

		public object DueAt { get; set; }

		public object ReceivedAt { get; set; }

		public string RetailerId { get; set; }

		public string OutletId { get; set; }

		public string SupplierId { get; set; }

		public string SourceOutletId { get; set; }

		public string Status { get; set; }

		public string Type { get; set; }

		public object AccountsTransactionId { get; set; }
	}
}
