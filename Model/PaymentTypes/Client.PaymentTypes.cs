using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string paymentTypesResourceName = "payment_types";

		public List<PaymentType> GetPaymentTypes()
		{
			return getResourceListAsync<PaymentTypeList>(paymentTypesResourceName).Result.PaymentTypes;
		}
	}
}
