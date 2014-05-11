using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Vend
{
	public partial class Client
	{
		const string productsResourceName = "products";

		// The public method used to retrieve the first page
		public List<Product> GetProducts()
		{
			return getResourceAsync<ProductList>(productsResourceName).Result.Products;
		}

		public async Task<List<Product>> GetProductsAsync()
		{
			var resources = await getResourceAsync<ProductList>(productsResourceName);
			return resources.Products;
		}


//		async Task<List<Product>> getProductListAsync<ProductList>(string resourceName, int page = 1)
//		{
//			var url = string.Concat(BaseUrl, resourceName);
//
//			var credentials = new NetworkCredential(Username, Password);
//			var handler = new HttpClientHandler { Credentials = credentials };
//			HttpResponseMessage response;
//			Pagination pagination;
//			List<Product> products;
//			ProductList resource;
//
//			using (var client = new HttpClient(handler)) {
//				response = await client.GetAsync(url);
//				var contentString = await response.Content.ReadAsStringAsync();
//				var result = JsonConvert.DeserializeObjectAsync<ProductList>(contentString).Result;
//				if (result != null) {
//					products = result.Products;
//					pagination = result.Pagination;
//					if (pagination.Pages > pagination.Page) {
//						products.AddRange(getProductListAsync<ProductList>(resourceName, pagination.Page + 1));
//					}
//
//
//				} else {
//					products = JsonConvert.DeserializeObjectAsync<List<Product>>(contentString).Result;
//				}
//				return products;
//			}
//		}


		// Generic method used by the both above
		// recursively grabs subsequent pages
//		List<Product> getProducts(string resourceName, int page = 1)
//		{
//			var request = new RestRequest(resourceName, Method.GET);
//			if (page > 1) {
//				request.AddParameter("page", page);
//			}
//			var response = Execute<ProductList>(request);
//			var products = response.Products;
//			var pagination = response.Pagination;
//			if (pagination.Pages > pagination.Page) {
//				products.AddRange(getProducts(resourceName, pagination.Page + 1));
//			}
//			return products;
//		}

//		public Product CreateProduct()
//		{
//			var product = new Product();
//			product.Handle = "TestProductHandle";
//			product.Type = "General";
//			product.Name = "API Test Product";
//			product.Sku = "12341234";
//			product.SupplyPrice = "45";
//
//			var productJson = SimpleJson.SerializeObject(product);
//
//			var request = new RestRequest(productsResourceName, Method.POST);
//			request.RequestFormat = DataFormat.Json;
//			request.AddParameter("application/json", productJson, ParameterType.RequestBody);
//			var response = Execute<ProductResponse>(request);
//			if (response.Product != null) {
//				Console.WriteLine("Created a product with id: {0}", response.Product.Id);
//			}
//			return response.Product;
//		}

		/// <summary>
		/// Deletes the product.
		/// </summary>
		/// <returns><c>true</c>, if product was deleted, <c>false</c> otherwise.</returns>
		/// <param name="productId">Product identifier.</param>
//		public bool DeleteProduct(string productId)
//		{
//			var resourceName = productsResourceName + "/" + productId;
//			var request = new RestRequest(resourceName, Method.DELETE);
//			var response = Execute(request);
//			if (response.ErrorException != null) {
//				return false;
//			}
//			Console.WriteLine("Deleted a product with id: {0}", productId);
//			return true;
//		}
	}
}
