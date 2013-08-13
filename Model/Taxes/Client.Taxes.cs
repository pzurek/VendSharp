using System.Collections.Generic;
using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<Tax> GetTaxes()
		{
			const string resourceName = "taxes"; // TODO: should be "suppliers"
			var request = new RestRequest(resourceName, Method.GET);
			var taxes = Execute<TaxList>(request).Taxes;
			return taxes;
		}
	}
}
