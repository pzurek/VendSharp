using System.Collections.Generic;

namespace Vend
{
	public partial class Client
	{
		const string registersResourceName = "registers";

		public List<Register> GetRegisters()
		{
			return getResourceListAsync<RegisterList>(registersResourceName).Result.Registers;
		}
	}
}
