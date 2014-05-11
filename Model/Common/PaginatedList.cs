using Newtonsoft.Json;

namespace Vend
{
	public class PaginatedList
	{
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }
	}
}
