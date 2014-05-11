using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string stockMovementsResourceName = "stock_movements";

		public List<StockMovement> GetStockMovements()
		{
			return getResourceListAsync<StockMovementList>(stockMovementsResourceName).Result.StockMovements;
		}
	}
}
