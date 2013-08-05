using System;

namespace Vend
{
	/// <summary>
	/// Customer.
	/// </summary>
	public class Customer : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the retailer identifier.
		/// </summary>
		/// <value>The retailer identifier.</value>
		public string RetailerId { get; set; }

		/// <summary>
		/// A short string code assigned to customers by the retailer.
		/// This code is arbitrary, and may be something a retailer uses to integrate Vend with their own customer tracking.
		/// </summary>
		/// <value>The cusomer code.</value>
		public string CustomerCode { get; set; }

		/// <summary>
		/// Gets or sets the balance.
		/// </summary>
		/// <value>The balance.</value>
		public float Balance { get; set; }

		/// <summary>
		/// Gets or sets the points.
		/// </summary>
		/// <value>The points.</value>
		public int Points { get; set; }

		/// <summary>
		/// Gets or sets the note.
		/// </summary>
		/// <value>The note.</value>
		public string Note { get; set; }

		/// <summary>
		/// Gets or sets the year to date spending.
		/// </summary>
		/// <value>The year to date spending.</value>
		public float YTD { get; set; }

		/// <summary>
		/// Gets or sets the sex.
		/// </summary>
		/// <value>The sex.</value>
		public string Sex { get; set; }

		/// <summary>
		/// Gets or sets the date of birth.
		/// </summary>
		/// <value>The date of birth.</value>
		public string DOB { get; set; }

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
		/// Gets or sets the created at.
		/// </summary>
		/// <value>The created at.</value>
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the contact.
		/// </summary>
		/// <value>The contact.</value>
		public Contact Contact { get; set; }

		public string FirstName {
			get { return Contact.FirstName; }
			set { Contact.FirstName = value; }
		}

		public string LastName {
			get { return Contact.LastName; }
			set { Contact.LastName = value; }
		}
	}
}
