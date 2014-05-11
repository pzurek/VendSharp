using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class StockMovementList : PaginatedList
	{
		[JsonProperty("stock_movements")]
		public List<StockMovement> StockMovements { get; set; }
	}
}
