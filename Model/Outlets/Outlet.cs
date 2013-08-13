namespace Vend
{
	/// <summary>
	/// Outlet.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class Outlet : BaseApiObject
	{
		public string RetailerId { get; set; }

		public string Name { get; set; }

		public string TimeZone { get; set; }

		public Contact Contact { get; set; }

		public string Email { get; set; }

		public string PhysicalAddress1 { get; set; }

		public string PhysicalAddress2 { get; set; }

		public string PhysicalSuburb { get; set; }

		public string PhysicalCity { get; set; }

		public string PhysicalPostcode { get; set; }

		public string PhysicalState { get; set; }

		public string PhysicalCountryId { get; set; }
	}
}
