using Newtonsoft.Json;

namespace Vend
{
	public class QuickKeysTemplate
	{
		[JsonProperty("quick_keys")]
		public QuickKeys QuickKeys { get; set; }
	}
}
