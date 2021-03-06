using System;

using Newtonsoft.Json;

using RestSharp;
using RestSharp.Extensions;

namespace Vend
{
	public partial class Client
	{
		public string BaseUrl;
		public string Username;
		public string Password;

		JsonSerializer jsonSerializer;

		public Client(string storeName, string username, string password)
		{
			BaseUrl = string.Format("https://{0}.vendhq.com/api/", storeName);
			Username = username;
			Password = password;

			jsonSerializer = new JsonSerializer();
			// That is the reason behind using Json.Net
			jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
		}

		public T Execute<T>(IRestRequest request) where T : new()
		{
			var client = new RestClient();
			client.BaseUrl = BaseUrl;
			client.Authenticator = new HttpBasicAuthenticator(Username, Password);

			var response = client.Execute<T>(request);

			if (response.ErrorException != null)
			{
				const string message = "Error retrieving response. Check inner details for more info.";
				var exception = new ApplicationException(message, response.ErrorException);
				throw exception;
			}
			return response.Data;
		}

		public IRestResponse Execute(IRestRequest request)
		{
			var client = new RestClient();
			client.BaseUrl = BaseUrl;
			client.Authenticator = new HttpBasicAuthenticator(Username, Password);

			var response = client.Execute(request);

			if (response.ErrorException != null)
			{
				const string message = "Error retrieving response. Check inner details for more info.";
				var exception = new ApplicationException(message, response.ErrorException);
				throw exception;
			}
			return response;
		}

		public bool DeleteResource(string resourceName, string id)
		{
			var resourceString = resourceName + "/" + id;
			var request = new RestRequest(resourceString, Method.DELETE);
			var response = Execute(request);
			if (response.ErrorException != null) {
				return false;
			}
			return true;
		}
	}
}
