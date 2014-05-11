using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string registerSalesResourceName = "register_sales";

		public List<RegisterSale> GetRegisterSales()
		{
			return getResourceListAsync<RegisterSaleList>(registerSalesResourceName).Result.RegisterSales;
		}
	}
}
