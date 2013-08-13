using System;
using System.Diagnostics;
using Vend;

namespace VendTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Stopwatch stopWatch = new Stopwatch();
			Client client = new Client("piotr", "piotr@vendhq.com", "v");
			stopWatch.Start();
			var users = client.GetUsers();
			stopWatch.Stop();
			Console.WriteLine("Got {0} users in {1} s", users.Count, stopWatch.ElapsedMilliseconds/1000.000);
			stopWatch.Reset();
			stopWatch.Start();
			var outlets = client.GetOutlets();
			stopWatch.Stop();
			Console.WriteLine("Got {0} outlets in {1} s", outlets.Count, stopWatch.ElapsedMilliseconds/1000.000);
			stopWatch.Reset();
			stopWatch.Start();
			var registers = client.GetRegisters();
			stopWatch.Stop();
			Console.WriteLine("Got {0} registers in {1} s",registers.Count, stopWatch.ElapsedMilliseconds/1000.000);
			stopWatch.Reset();
			stopWatch.Start();
			var products = client.GetProducts();
			stopWatch.Stop();
			Console.WriteLine("Got {0} products in {1} s", products.Count, stopWatch.ElapsedMilliseconds/1000.000);
			stopWatch.Reset();
			stopWatch.Start();
			var customers = client.GetCustomers();
			stopWatch.Stop();
			Console.WriteLine("Got {0} customers in {1} s", customers.Count, stopWatch.ElapsedMilliseconds/1000.000);
			stopWatch.Reset();
			stopWatch.Start();
			var taxes = client.GetTaxes();
			stopWatch.Stop();
			Console.WriteLine("Got {0} taxes in {1} s", taxes.Count, stopWatch.ElapsedMilliseconds / 1000.000);
			stopWatch.Reset();
			stopWatch.Start();
			var paymentTypes = client.GetPaymentTypes();
			stopWatch.Stop();
			Console.WriteLine("Got {0} payment types in {1} s", paymentTypes.Count, stopWatch.ElapsedMilliseconds/1000.000);
			stopWatch.Reset();
			stopWatch.Start();
			var registerSales = client.GetRegisterSales();
			stopWatch.Stop();
			Console.WriteLine("Got {0} register sales in {1} s", registerSales.Count, stopWatch.ElapsedMilliseconds/1000.000);
			stopWatch.Reset();
			stopWatch.Start();
			var suppliers = client.GetSuppliers();
			stopWatch.Stop();
			Console.WriteLine("Got {0} suppliers in {1} s", suppliers.Count, stopWatch.ElapsedMilliseconds/1000.000);
		}
	}
}
