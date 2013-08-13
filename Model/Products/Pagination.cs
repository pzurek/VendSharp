namespace Vend
{
	/// <summary>
	/// Pagination.
	/// </summary>
	/// <remarks>Based on 0.x API payload</remarks>
	public class Pagination
	{
		public int Results { get; set; }

		public int Page { get; set; }

		public int PageSize { get; set; }

		public int Pages { get; set; }
	}
}
