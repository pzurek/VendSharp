using System.Collections.Generic;
using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<PaymentType> GetPaymentTypes()
		{
			const string resourceName = "payment_types"; // TODO: should be "suppliers"
			var request = new RestRequest(resourceName, Method.GET);
			var paymentTypes = Execute<PaymentTypeList>(request).PaymentTypes;
			return paymentTypes;
		}
	}
}
