using System.Collections.Generic;

using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<Outlet> GetOutlets()
		{
			const string resourceName = "outlets";
			var request = new RestRequest(resourceName, Method.GET);
			var outlets = Execute<OutletList>(request).Outlets;
			return outlets;
		}
	}
}
