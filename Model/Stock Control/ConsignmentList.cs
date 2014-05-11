using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class ConsignmentList : PaginatedList
	{
		[JsonProperty("consignments")]
		public List<Consignment> Consignments { get; set; }
	}
}
