using System;
using System.Collections.Generic;

using RestSharp;

using Newtonsoft.Json;

namespace Vend
{
	public partial class Client
	{
		const string taxResourceName = "taxes";

		public List<Tax> GetTaxes()
		{
			var request = new RestRequest(taxResourceName, Method.GET);
			var taxes = Execute<TaxList>(request).Taxes;
			return taxes;
		}

		public Tax CreateTax(Tax tax)
		{
			var taxJson = JsonConvert.SerializeObject(tax, Formatting.Indented);
			var request = new RestRequest(taxResourceName, Method.POST);
			request.AddParameter("application/json", taxJson, ParameterType.RequestBody);
			var response = Execute<TaxResponse>(request).Tax;

			return response;
		}

		// Yeah, nah... Don't do that. The API doesn't allow it.
//		public bool DeleteTax(string id)
//		{
//			var result = DeleteResource(taxResourceName, id);
//			return result;
//		}
	}
}
