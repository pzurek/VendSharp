using Newtonsoft.Json;

namespace Vend
{
	public class Receipt
	{
		[JsonProperty("fields")]
		public Fields Fields { get; set; }
	}
}
