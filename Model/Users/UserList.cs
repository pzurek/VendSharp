using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// User list.
	/// </summary>
	public class UserList : PaginatedList
	{
		[JsonProperty("users")]
		public List<User> Users { get; set; }
	}
}
