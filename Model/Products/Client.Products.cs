using System.Collections.Generic;

using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<Product> GetProducts()
		{
			const string resourceName = "products";
			var request = new RestRequest(resourceName, Method.GET);
			var products = Execute<ProductListPage>(request).Products;
			return products;
		}
	}
}
