using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Vend
{
	public class Client
	{
		public Client()
		{
			HttpClient httpClient = new HttpClient();
			httpClient.BaseAddress = new Uri("http://piotr.vendhq.com");
		}

		public static List<User> GetUsers()
		{
			var users = new List<User>();
			return users;
		}

		public static List<Register> GetRegisters()
		{
			var registers = new List<Register>();

			return registers;
		}

		public static List<Product> GetProducts()
		{
			var products = new List<Product>();

			return products;
		}

		public static List<Customer> GetCustomers()
		{
			var customers = new List<Customer>();


			return customers;
		}
	}
}
