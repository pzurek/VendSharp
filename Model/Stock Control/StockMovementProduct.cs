namespace Vend
{
	public class StockMovementProduct : BaseApiObject
	{
		public string ProductId { get; set; }

		public string Name { get; set; }

		public string Count { get; set; }

		public string Received { get; set; }

		public string Cost { get; set; }

		public string CreatedAt { get; set; }

		public string UpdatedAt { get; set; }
	}
}
