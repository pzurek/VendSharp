using System.Collections.Generic;

namespace Vend
{
	public class ProductListPage
	{
		public Pagination Pagination { get; set; }

		public List<Product> Products { get; set; }
	}
}
