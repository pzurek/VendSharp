using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Extensions;
using RestSharp.Contrib;
using RestSharp.Validation;
using RestSharp.Deserializers;
using RestSharp.Serializers;

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
