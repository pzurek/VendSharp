using Newtonsoft.Json;

namespace Vend
{
	public class TaxResponse
	{		
		[JsonProperty("tax")]
		public Tax Tax { get; set; }
	}
}
