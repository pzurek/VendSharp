using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string taxesResourceName = "taxes";

		public List<Tax> GetTaxes()
		{
			return getResourceListAsync<TaxList>(taxesResourceName).Result.Taxes;
		}

		public Tax CreateTax(Tax tax)
		{
			return createResourceAsync<Tax>(tax, taxesResourceName).Result;
		}
	}
}
