using System;
using System.Diagnostics;
using Vend;

namespace VendTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Stopwatch totalStopwatch = new Stopwatch();
			Stopwatch singleStopwatch = new Stopwatch();
			Client client = new Client("piotr", "piotr@vendhq.com", "v");
			totalStopwatch.Start();
			singleStopwatch.Start();
			var users = client.GetUsers();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} users in {1} s", users.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var outlets = client.GetOutlets();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} outlets in {1} s", outlets.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var registers = client.GetRegisters();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} registers in {1} s", registers.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var products = client.GetProducts();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} products in {1} s", products.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var customers = client.GetCustomers();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} customers in {1} s", customers.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var taxes = client.GetTaxes();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} taxes in {1} s", taxes.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var paymentTypes = client.GetPaymentTypes();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} payment types in {1} s", paymentTypes.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var registerSales = client.GetRegisterSales();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} register sales in {1} s", registerSales.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var suppliers = client.GetSuppliers();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} suppliers in {1} s", suppliers.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var consignments = client.GetConsignemnts();
			singleStopwatch.Stop();
			Console.WriteLine("Got {0} consignments in {1} s", consignments.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			singleStopwatch.Reset();
			singleStopwatch.Start();
			var stockMovements = client.GetStockMovements();
			singleStopwatch.Stop();
			totalStopwatch.Stop();
			Console.WriteLine("Got {0} stock movements in {1} s", stockMovements.Count, singleStopwatch.ElapsedMilliseconds / 1000.000);
			Console.WriteLine("The whole process took {0} s.", totalStopwatch.ElapsedMilliseconds / 1000.000);
		}
	}
}
