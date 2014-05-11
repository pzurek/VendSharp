using Newtonsoft.Json;

namespace Vend
{
	public class ConfigRoot
	{
		[JsonProperty("config")]
		public Config Config { get; set; }
	}
}
