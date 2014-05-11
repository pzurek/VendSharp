using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Attribute.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class Attribute
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
