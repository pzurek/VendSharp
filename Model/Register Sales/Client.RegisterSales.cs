using System.Collections.Generic;
using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<RegisterSale> GetRegisterSales()
		{
			const string resourceName = "register_sales";
			var request = new RestRequest(resourceName, Method.GET);
			var register_sales = Execute<RegisterSaleList>(request).RegisterSales;
			return register_sales;
		}
	}
}
