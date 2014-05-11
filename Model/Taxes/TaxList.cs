using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class TaxList : PaginatedList
	{
		[JsonProperty("taxes")]
		public List<Tax> Taxes { get; set; }
	}
}
