using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	public class PaymentTypeList : PaginatedList
	{
		[JsonProperty("payment_types")]
		public List<PaymentType> PaymentTypes { get; set; }
	}
}
