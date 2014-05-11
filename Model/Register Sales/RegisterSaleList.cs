using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class RegisterSaleList : PaginatedList
	{
		[JsonProperty("register_sales")]
		public List<RegisterSale> RegisterSales { get; set; }
	}
}
