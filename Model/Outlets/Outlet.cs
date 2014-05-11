using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Outlet.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class Outlet : BaseApiObject
	{
		[JsonProperty("retailer_id")]
		public string RetailerId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("timezone")]
		public string TimeZone { get; set; }

		[JsonProperty("contact")]
		public Contact Contact { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("physical_address1")]
		public string PhysicalAddress1 { get; set; }

		[JsonProperty("physical_address2")]
		public string PhysicalAddress2 { get; set; }

		[JsonProperty("physical_suburb")]
		public string PhysicalSuburb { get; set; }

		[JsonProperty("physical_city")]
		public string PhysicalCity { get; set; }

		[JsonProperty("physical_postcode")]
		public string PhysicalPostcode { get; set; }

		[JsonProperty("physical_state")]
		public string PhysicalState { get; set; }

		[JsonProperty("physical_country_id")]
		public string PhysicalCountryId { get; set; }
	}
}
