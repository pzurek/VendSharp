using Newtonsoft.Json;

namespace Vend
{
	public class Contact
	{

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("company_name")]
		public string CompanyName { get; set; }

		[JsonProperty("phone")]
		public string Phone { get; set; }

		[JsonProperty("mobile")]
		public string Mobile { get; set; }

		[JsonProperty("fax")]
		public string Fax { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("twitter")]
		public string Twitter { get; set; }

		[JsonProperty("website")]
		public object Website { get; set; }

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

		[JsonProperty("postal_address1")]
		public string PostalAddress1 { get; set; }

		[JsonProperty("postal_address2")]
		public string PostalAddress2 { get; set; }

		[JsonProperty("postal_suburb")]
		public string PostalSuburb { get; set; }

		[JsonProperty("postal_city")]
		public string PostalCity { get; set; }

		[JsonProperty("postal_postcode")]
		public string PostalPostcode { get; set; }

		[JsonProperty("postal_state")]
		public string PostalState { get; set; }

		[JsonProperty("postal_country_id")]
		public string PostalCountryId { get; set; }
	}
}
