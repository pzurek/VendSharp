using System;

namespace Vend
{
	public class User : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the username.
		/// </summary>
		/// <value>The username.</value>
		public string Username { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the outlet identifier.
		/// </summary>
		/// <value>The outlet identifier.</value>
		public string OutletId { get; set; }

		/// <summary>
		/// Gets or sets the name of the outlet.
		/// </summary>
		/// <value>The name of the outlet.</value>
		public string OutletName { get; set; }

		/// <summary>
		/// Gets or sets the type of the account.
		/// </summary>
		/// <value>The type of the account.</value>
		public string AccountType { get; set; }
	}
}

