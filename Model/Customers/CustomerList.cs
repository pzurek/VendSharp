using System.Collections.Generic;

namespace Vend
{
	public class CustomerList : PaginatedList
	{
		public List<Customer> Customers { get; set; }
	}
}
