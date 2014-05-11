using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Register list.
	/// </summary>
	public class RegisterList : PaginatedList
	{
		[JsonProperty("registers")]
		public List<Register> Registers { get; set; }
	}
}
