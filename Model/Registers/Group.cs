using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class Group
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("position")]
		public int Position { get; set; }

		[JsonProperty("pages")]
		public List<Page> Pages { get; set; }
	}
}
