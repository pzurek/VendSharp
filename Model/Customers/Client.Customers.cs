using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string customersResourceName = "customers";

		public List<Customer> GetCustomers()
		{
			return getResourceListAsync<CustomerList>(customersResourceName).Result.Customers;
		}

		public Customer CreateCustomer(Customer customer)
		{
			return createResourceAsync<Customer>(customer, customersResourceName).Result;
		}
	}
}
