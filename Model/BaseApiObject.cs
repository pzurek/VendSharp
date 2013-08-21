using Newtonsoft.Json;

namespace Vend
{
	public class BaseApiObject
	{
		/// <summary>
		/// A 128-bit unique identifier, in hexadecimal string form, using the format aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee.
		/// UUIDs are intended to be unique, but are not unpredictable or unguessable.
		/// </summary>
		/// <value>The identifier.</value>
		[JsonIgnore]
		public string Id { get; set; }
	}
}

