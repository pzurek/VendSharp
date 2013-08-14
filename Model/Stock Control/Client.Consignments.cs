using System.Collections.Generic;
using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<Consignment> GetConsignemnts()
		{
			const string resourceName = "consignment"; // TODO: plural would be nice?
			var request = new RestRequest(resourceName, Method.GET);
			var consignments = Execute<ConsignmentList>(request).Consignments;
			return consignments;
		}
	}
}
