namespace Vend
{
	public class Supplier : BaseApiObject
	{
		public string RetailerId { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string Source { get; set; }

		public SupplierContact Contact { get; set; }
	}
}
