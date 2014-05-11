using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class SupplierList : PaginatedList
	{
		[JsonProperty("suppliers")]
		public List<Supplier> Suppliers { get; set; }
	}
}
