using Newtonsoft.Json;

namespace Vend
{
	public class User : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the username.
		/// </summary>
		/// <value>The username.</value>
		[JsonProperty("username")]
		public string Username { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the outlet identifier.
		/// </summary>
		/// <value>The outlet identifier.</value>
		[JsonProperty("outlet_id")]
		public string OutletId { get; set; }

		/// <summary>
		/// Gets or sets the name of the outlet.
		/// </summary>
		/// <value>The name of the outlet.</value>
		[JsonProperty("outlet_name")]
		public string OutletName { get; set; }

		/// <summary>
		/// Gets or sets the type of the account.
		/// </summary>
		/// <value>The type of the account.</value>
		[JsonProperty("account_type")]
		public string AccountType { get; set; }
	}
}
