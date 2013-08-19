using RestSharp;

namespace Vend
{
	public partial class Client
	{
		const string configResourceName = "config";

		/// <summary>
		/// Returns all active users for the current retailer.
		/// </summary>
		public Config GetConfig()
		{
			var request = new RestRequest(configResourceName, Method.GET);
			var config = Execute<ConfigRoot>(request).Config;
			return config;
		}
	}
}
