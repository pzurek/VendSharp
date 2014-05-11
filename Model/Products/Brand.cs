using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Brand.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class Brand : BaseApiObject
	{
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
