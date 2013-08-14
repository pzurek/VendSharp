using System.Collections.Generic;
using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<StockMovement> GetStockMovements()
		{
			const string resourceName = "stock_movements";
			var request = new RestRequest(resourceName, Method.GET);
			var stockMovements = Execute<StockMovementList>(request).StockMovements;
			return stockMovements;
		}
	}
}
