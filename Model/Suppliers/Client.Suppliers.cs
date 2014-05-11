using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string supplierResourceName = "supplier"; // TODO: should be "suppliers"

		public List<Supplier> GetSuppliers()
		{
			return getResourceListAsync<SupplierList>(supplierResourceName).Result.Suppliers;
		}

		public Supplier CreateSuplier(Supplier supplier)
		{
			return createResourceAsync<Supplier>(supplier, supplierResourceName).Result;
		}

		public Supplier UpdateSupplier(Supplier supplier)
		{
			return createResourceAsync<Supplier>(supplier, supplierResourceName).Result;
		}

		public bool DeleteSupplier(string id)
		{
			return deleteResourceAsync(supplierResourceName, id).Result;
		}
	}
}
