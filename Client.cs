using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
			jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
		}

		async Task<T> getResourceAsync<T>(string resourceName, string id)
		{
			var url = string.Concat(BaseUrl, resourceName, "/", id);
			return await getResourceBaseAsync<T>(url);
		}

		async Task<T> getResourceAsync<T>(string resourceName)
		{
			var url = string.Concat(BaseUrl, resourceName);
			return await getResourceBaseAsync<T>(url);
		}

		async Task<T> getResourceBaseAsync<T>(string url)
		{
			var credentials = new NetworkCredential(Username, Password);
			var handler = new HttpClientHandler { Credentials = credentials };

			using (var client = new HttpClient(handler)) {
				var response = await client.GetAsync(url);
				var contentString = await response.Content.ReadAsStringAsync();
				var resource = await JsonConvert.DeserializeObjectAsync<T>(contentString);
				return resource;
			}
		}

		async Task<T> getResourceListAsync<T>(string resourceName)
		{
			var url = string.Concat(BaseUrl, resourceName);

			var credentials = new NetworkCredential(Username, Password);
			var handler = new HttpClientHandler { Credentials = credentials };

			using (var client = new HttpClient(handler)) {
				var response = await client.GetAsync(url);
				var contentString = await response.Content.ReadAsStringAsync();
				var resource = await JsonConvert.DeserializeObjectAsync<T>(contentString);
				return resource;
			}
		}

		async Task<T> createResourceAsync<T>(T obj, string resourceName) where T  : new()
		{
			var objectJson = JsonConvert.SerializeObject(obj, Formatting.Indented);
			HttpContent httpContent = new StringContent(objectJson);

			var url = string.Concat(BaseUrl, resourceName);
			var credentials = new NetworkCredential(Username, Password);
			var handler = new HttpClientHandler { Credentials = credentials };

			using (var client = new HttpClient(handler)) {
				var responseTask = client.PostAsync(url, httpContent);
				var response = await responseTask;
				var json = await response.Content.ReadAsStringAsync();
				var root = JObject.Parse(json);
				var first = root.First.First;
				var result = await JsonConvert.DeserializeObjectAsync<T>(first.ToString());
				return result;
			}
		}

		async Task<bool> deleteResourceAsync(string resourceName, string id)
		{
			var url = string.Concat(BaseUrl, resourceName, "/", id);

			var credentials = new NetworkCredential(Username, Password);
			var handler = new HttpClientHandler { Credentials = credentials };

			using (var client = new HttpClient(handler)) {
				var response = await client.DeleteAsync(url);
				if (response.StatusCode == HttpStatusCode.OK)
					return true;
				return false;
			}
		}
	}
}
