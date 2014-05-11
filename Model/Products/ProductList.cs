using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class ProductList : PaginatedList
	{
		[JsonProperty("products")]
		public List<Product> Products { get; set; }
	}
}
