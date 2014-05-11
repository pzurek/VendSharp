using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Customer contact.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class CustomerContact
	{

		[JsonProperty("company_name")]
		public string CompanyName { get; set; }

		[JsonProperty("phone")]
		public string Phone { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }
	}
}
