using System.Collections.Generic;

using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<Customer> GetCustomers()
		{
			const string resourceName = "customers";
			var request = new RestRequest(resourceName, Method.GET);
			var customers = Execute<CustomerList>(request).Customers;
			return customers;
		}
	}
}
