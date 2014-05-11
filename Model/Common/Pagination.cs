using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Pagination.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class Pagination
	{
		[JsonProperty("results")]
		public int Results { get; set; }

		[JsonProperty("page")]
		public int Page { get; set; }

		[JsonProperty("page_size")]
		public int PageSize { get; set; }

		[JsonProperty("pages")]
		public int Pages { get; set; }
	}
}
