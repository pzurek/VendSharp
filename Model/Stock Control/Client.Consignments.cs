using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string consignmentsResourceName = "consignment"; // TODO: plural would be nice?

		public List<Consignment> GetConsignemnts()
		{
			return getResourceListAsync<ConsignmentList>(consignmentsResourceName).Result.Consignments;
		}
	}
}
