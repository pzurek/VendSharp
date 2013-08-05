using System;

namespace Vend
{
	/// <summary>
	/// Contact.
	/// That is the object inferred based on the response content.
	/// <seealso cref="Vend.Contact"/>
	/// </summary>
	public class CustomerContact
	{
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
		/// Gets or sets the email.
		/// </summary>
		/// <value>The email.</value>
		public string Email { get; set; }
	}
}
