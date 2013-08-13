using System.Collections.Generic;

using RestSharp;

namespace Vend
{
	public partial class Client
	{
		public List<Register> GetRegisters()
		{
			const string resourceName = "registers";
			var request = new RestRequest(resourceName, Method.GET);
			var registers = Execute<RegisterList>(request).Registers;
			return registers;
		}
	}
}
