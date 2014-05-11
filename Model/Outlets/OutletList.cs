using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Outlet list.
	/// </summary>
	public class OutletList : PaginatedList
	{
		[JsonProperty("outlets")]
		public List<Outlet> Outlets { get; set; }
	}
}
