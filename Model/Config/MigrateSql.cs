using Newtonsoft.Json;

namespace Vend
{
	public class MigrateSql
	{
		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("table")]
		public string Table { get; set; }

		[JsonProperty("query")]
		public string Query { get; set; }
	}
}
