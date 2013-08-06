using System;
using System.Collections.Generic;
using Vend;

namespace VendTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<User> user = Vend.Client.GetUsers ();
		}
	}
}
