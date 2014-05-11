using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class QuickKeys
	{
		[JsonProperty("groups")]
		public List<Group> Groups { get; set; }
	}
}
