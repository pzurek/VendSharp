using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string outletsResourceName = "outlets";

		public List<Outlet> GetOutlets()
		{
			return getResourceListAsync<OutletList>(outletsResourceName).Result.Outlets;
		}
	}
}
