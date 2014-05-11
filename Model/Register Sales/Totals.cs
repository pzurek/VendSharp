using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Totals.
	/// </summary>
	/// <remarks>Based on 0.x API payload.</remarks>
	public class Totals
	{
		[JsonProperty("total_tax")]
		public double TotalTax { get; set; }

		[JsonProperty("total_price")]
		public double TotalPrice { get; set; }

		[JsonProperty("total_payment")]
		public double TotalPayment { get; set; }

		[JsonProperty("total_to_pay")]
		public double TotalToPay { get; set; }
	}
}
