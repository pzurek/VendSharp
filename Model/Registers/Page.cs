using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class Page
	{
		[JsonProperty("page")]
		public int PageNumber { get; set; }

		[JsonProperty("keys")]
		public List<Key> Keys { get; set; }
	}
}
