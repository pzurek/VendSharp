using System;

namespace Vend
{
	/// <summary>
	/// Outlet.
	/// </summary>
	public class Outlet : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the retailer identifier.
		/// </summary>
		/// <value>The retailer identifier.</value>
		public string RetailerId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the time zone.
		/// </summary>
		/// <value>The time zone.</value>
		public string TimeZone { get; set; }

		/// <summary>
		/// Gets or sets the contact.
		/// </summary>
		/// <value>The contact.</value>
		public Contact Contact { get; set; }

		// TODO: all this data could come from the Contact object above

		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>The email.</value>
		public string Email { get; set; }

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
	}
}
