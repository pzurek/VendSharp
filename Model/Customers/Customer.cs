using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Customer.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class Customer : BaseApiObject
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("customer_code")]
		public string CustomerCode { get; set; }

		[JsonProperty("customer_group_id")]
		public string CustomerGroupId { get; set; }

		[JsonProperty("customer_group_name")]
		public string CustomerGroupName { get; set; }

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
		public string Website { get; set; }

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

		[JsonProperty("enable_loayaly")]
		public int EnableLoyalty { get; set; }

		[JsonProperty("loyalty_balance")]
		public string LoyaltyBalance { get; set; }

		[JsonProperty("updated_at")]
		public string UpdatedAt { get; set; }

		[JsonProperty("deleted_at")]
		public string DeletedAt { get; set; }

		[JsonProperty("balance")]
		public string Balance { get; set; }

		[JsonProperty("year_to_date")]
		public string YearToDate { get; set; }

		[JsonProperty("date_of_birth")]
		public string DateOfBirth { get; set; }

		[JsonProperty("sex")]
		public string Sex { get; set; }

		[JsonProperty("custom_field_1")]
		public string CustomField1 { get; set; }

		[JsonProperty("custom_field_2")]
		public string CustomField2 { get; set; }

		[JsonProperty("custom_field_3")]
		public string CustomField3 { get; set; }

		[JsonProperty("custom_field_4")]
		public string CustomField4 { get; set; }

		[JsonProperty("contact")]
		public CustomerContact Contact { get; set; }
	}
}
