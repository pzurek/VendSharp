namespace Vend
{
	public partial class Client
	{
		const string configResourceName = "config";

		public Config GetConfig()
		{
			return getResourceAsync<ConfigRoot>(configResourceName).Result.Config;
		}
	}
}
