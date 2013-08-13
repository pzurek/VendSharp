using System.Collections.Generic;

using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<Supplier> GetSuppliers()
		{
			const string resourceName = "supplier"; // TODO: should be "suppliers"
			var request = new RestRequest(resourceName, Method.GET);
			var suppliers = Execute<SupplierList>(request).Suppliers;
			return suppliers;
		}
	}
}
