using System;

using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public string BaseUrl;
		public string StoreName;
		public string Username;
		public string Password;

		public Client(string storeName, string username, string password)
		{
			BaseUrl = string.Format("https://{0}.vendhq.com/api/", storeName);
			Username = username;
			Password = password;
		}

		public T Execute<T>(IRestRequest request) where T : new()
		{
			var client = new RestClient();
			client.BaseUrl = BaseUrl;
			client.Authenticator = new HttpBasicAuthenticator(Username, Password);

			var response = client.Execute<T>(request);

			if (response.ErrorException != null)
			{
				const string message = "Error retrieving response.  Check inner details for more info.";
				var exception = new ApplicationException(message, response.ErrorException);
				throw exception;
			}
			return response.Data;
		}
	}
}
