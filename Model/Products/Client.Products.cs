using System;
using System.Collections.Generic;

using RestSharp;

namespace Vend
{
	public partial class Client
	{
		const string productsResourceName = "products";

		// The public method used to retrieve the first page
		public List<Product> GetProducts()
		{
			var products = getProducts(productsResourceName);
			return products;
		}

		// Generic method used by the both above
		// recursively grabs subsequent pages
		List<Product> getProducts(string resourceName, int page = 1)
		{
			var request = new RestRequest(resourceName, Method.GET);
			if (page > 1) {
				request.AddParameter("page", page);
			}
			var response = Execute<ProductListPage>(request);
			var products = response.Products;
			var pagination = response.Pagination;
			if (pagination.Pages > pagination.Page) {
				products.AddRange(getProducts(resourceName, pagination.Page + 1));
			}
			return products;
		}

		/// <summary>
		/// Deletes the product.
		/// </summary>
		/// <returns><c>true</c>, if product was deleted, <c>false</c> otherwise.</returns>
		/// <param name="productId">Product identifier.</param>
		public bool DeleteProduct(string productId)
		{
			var resourceName = productsResourceName + "/" + productId;
			var request = new RestRequest(resourceName, Method.DELETE);
			var response = Execute(request);
			if (response.ErrorException != null) {
				return false;
			}
			Console.WriteLine("Deleted a product with id: {0}", productId);
			return true;
		}
	}
}
