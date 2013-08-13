namespace Vend
{
	/// <summary>
	/// Customer.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class Customer : BaseApiObject
	{
		public string Name { get; set; }

		public string CustomerCode { get; set; }

		public string CustomerGroupId { get; set; }

		public string CustomerGroupName { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string CompanyName { get; set; }

		public string Phone { get; set; }

		public string Mobile { get; set; }

		public string Fax { get; set; }

		public string Email { get; set; }

		public string Twitter { get; set; }

		public string Website { get; set; }

		public string PhysicalAddress1 { get; set; }

		public string PhysicalAddress2 { get; set; }

		public string PhysicalSuburb { get; set; }

		public string PhysicalCity { get; set; }

		public string PhysicalPostcode { get; set; }

		public string PhysicalState { get; set; }

		public string PhysicalCountryId { get; set; }

		public string PostalAddress1 { get; set; }

		public string PostalAddress2 { get; set; }

		public string PostalSuburb { get; set; }

		public string PostalCity { get; set; }

		public string PostalPostcode { get; set; }

		public string PostalState { get; set; }

		public string PostalCountryId { get; set; }

		public int EnableLoyalty { get; set; }

		public string LoyaltyBalance { get; set; }

		public string UpdatedAt { get; set; }

		public string DeletedAt { get; set; }

		public string Balance { get; set; }

		public string YearToDate { get; set; }

		public string DateOfBirth { get; set; }

		public string Sex { get; set; }

		public string CustomField1 { get; set; }

		public string CustomField2 { get; set; }

		public string CustomField3 { get; set; }

		public string CustomField4 { get; set; }

		public CustomerContact Contact { get; set; }
	}
}
