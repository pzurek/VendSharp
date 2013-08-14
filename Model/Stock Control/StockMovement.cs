using System.Collections.Generic;

namespace Vend
{
	public class StockMovement : BaseApiObject
	{
		public string Name { get; set; }

		public string Type { get; set; }

		public string Date { get; set; }

		public string OutletId { get; set; }

		public string SupplierId { get; set; }

		public string Status { get; set; }

		public string ReceivedAt { get; set; }

		public string CreatedAt { get; set; }

		public string UpdatedAt { get; set; }

		public string SourceOutletId { get; set; }

		public string DueAt { get; set; }

		public List<StockMovementProduct> Products { get; set; }
	}
}
