using System.Collections.Generic;

using RestSharp;

namespace Vend
{
	public partial class Client
	{
		// The public method used to retrieve the first page
		public List<Product> GetProducts()
		{
			const string resourceName = "products";
			var products = GetProducts(resourceName);
			return products;
		}

		// Private method used to retrieve 2+ pages
		List<Product> GetProducts(int page)
		{
			string pageResourceName = string.Format("products/?page={0}", page.ToString());
			var products = GetProducts(pageResourceName);
			return products;
		}

		// Generic method used by the both above
		// recursively grabs subsequent pages
		List<Product> GetProducts(string pageResourceName)
		{
			var request = new RestRequest(pageResourceName, Method.GET);
			var response = Execute<ProductListPage>(request);
			var products = response.Products;
			var pagination = response.Pagination;
			if (pagination.Pages > pagination.Page) {
				products.AddRange(GetProducts(pagination.Page + 1));
			}
			return products;
		}
	}
}
