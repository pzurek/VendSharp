using System;

namespace Vend
{
	/// <summary>
	/// Customer.
	/// </summary>
	public class Customer : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// A short string code assigned to customers by the retailer.
		/// This code is arbitrary, and may be something a retailer uses to integrate Vend with their own customer tracking.
		/// </summary>
		/// <value>The cusomer code.</value>
		public string CustomerCode { get; set; }

		/// <summary>
		/// Gets or sets the customer group identifier.
		/// </summary>
		/// <value>The customer group identifier.</value>
		public string CustomerGroupId { get; set; }

		/// <summary>
		/// Gets or sets the name of the customer group.
		/// </summary>
		/// <value>The name of the customer group.</value>
		public string CustomerGroupName { get; set; }

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		public string FirstName { get; set; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		public string LastName { get; set; }

		/// <summary>
		/// Gets or sets the name of the company.
		/// </summary>
		/// <value>The name of the company.</value>
		public string CompanyName { get; set; }

		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
		public string Phone { get; set; }

		/// <summary>
		/// Gets or sets the mobile.
		/// </summary>
		/// <value>The mobile.</value>
		public string Mobile { get; set; }

		/// <summary>
		/// Gets or sets the fax.
		/// </summary>
		/// <value>The fax.</value>
		public string Fax { get; set; }

		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>The email.</value>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the twitter.
		/// </summary>
		/// <value>The twitter.</value>
		public string Twitter { get; set; }

		/// <summary>
		/// Gets or sets the website.
		/// </summary>
		/// <value>The website.</value>
		public string Website {get; set; }

		/// <summary>
		/// Gets or sets the physical address1.
		/// </summary>
		/// <value>The physical address1.</value>
		public string PhysicalAddress1 { get; set; }

		/// <summary>
		/// Gets or sets the physical address2.
		/// </summary>
		/// <value>The physical address2.</value>
		public string PhysicalAddress2 { get; set; }

		/// <summary>
		/// Gets or sets the physical suburb.
		/// </summary>
		/// <value>The physical suburb.</value>
		public string PhysicalSuburb { get; set; }

		/// <summary>
		/// Gets or sets the physical city.
		/// </summary>
		/// <value>The physical city.</value>
		public string PhysicalCity { get; set; }

		/// <summary>
		/// Gets or sets the physical postcode.
		/// </summary>
		/// <value>The physical postcode.</value>
		public string PhysicalPostcode { get; set; }

		/// <summary>
		/// Gets or sets the state of the physical.
		/// </summary>
		/// <value>The state of the physical.</value>
		public string PhysicalState { get; set; }

		/// <summary>
		/// Gets or sets the physical country identifier.
		/// </summary>
		/// <value>The physical country identifier.</value>
		public string PhysicalCountryId { get; set; }

		/// <summary>
		/// Gets or sets the postal address1.
		/// </summary>
		/// <value>The postal address1.</value>
		public string PostalAddress1 { get; set; }

		/// <summary>
		/// Gets or sets the postal address2.
		/// </summary>
		/// <value>The postal address2.</value>
		public string PostalAddress2 { get; set; }

		/// <summary>
		/// Gets or sets the postal suburb.
		/// </summary>
		/// <value>The postal suburb.</value>
		public string PostalSuburb { get; set; }

		/// <summary>
		/// Gets or sets the postal city.
		/// </summary>
		/// <value>The postal city.</value>
		public string PostalCity { get; set; }

		/// <summary>
		/// Gets or sets the postal postcode.
		/// </summary>
		/// <value>The postal postcode.</value>
		public string PostalPostcode { get; set; }

		/// <summary>
		/// Gets or sets the state of the postal.
		/// </summary>
		/// <value>The state of the postal.</value>
		public string PostalState { get; set; }

		/// <summary>
		/// Gets or sets the postal country identifier.
		/// </summary>
		/// <value>The postal country identifier.</value>
		public string PostalCountryId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Customer"/> has loyalty enabled.
		/// </summary>
		/// <value><c>true</c> if loyalty enabled; otherwise, <c>false</c>.</value>
		public bool LoyaltyEnabled { get; set; }

		/// <summary>
		/// Gets or sets the loyalty balance.
		/// </summary>
		/// <value>The loyalty balance.</value>
		public float LoyaltyBalance { get; set; }

		/// <summary>
		/// Gets or sets the updated at.
		/// </summary>
		/// <value>The updated at.</value>
		public DateTime UpdatedAt { get; set; }

		/// <summary>
		/// Gets or sets the deleted at.
		/// </summary>
		/// <value>The deleted at.</value>
		public DateTime DeletedAt { get; set; }

		/// <summary>
		/// Gets or sets the balance.
		/// </summary>
		/// <value>The balance.</value>
		public float Balance { get; set; }

		/// <summary>
		/// Gets or sets the year to date spending.
		/// </summary>
		/// <value>The year to date spending.</value>
		public float YTD { get; set; }

		/// <summary>
		/// Gets or sets the date of birth.
		/// </summary>
		/// <value>The date of birth.</value>
		public string DOB { get; set; }
		
		/// <summary>
		/// Gets or sets the sex.
		/// </summary>
		/// <value>The sex.</value>
		public string Sex { get; set; }

		/// <summary>
		/// Gets or sets the custom field.
		/// </summary>
		/// <value>The custom field.</value>
		public string CustomField1 { get; set; }

		/// <summary>
		/// Gets or sets the custom field2.
		/// </summary>
		/// <value>The custom field2.</value>
		public string CustomField2 { get; set; }

		/// <summary>
		/// Gets or sets the custom field3.
		/// </summary>
		/// <value>The custom field3.</value>
		public string CustomField3 { get; set; }

		/// <summary>
		/// Gets or sets the custom field4.
		/// </summary>
		/// <value>The custom field4.</value>
		public string CustomField4 { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="Vend.CustomerContact"/>
		/// </summary>
		/// <value>The contact.</value>
		public CustomerContact Contact { get; set; }
	}
}
