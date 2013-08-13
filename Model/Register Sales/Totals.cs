namespace Vend
{
	/// <summary>
	/// Totals.
	/// </summary>
	/// <remarks>Based on 0.x API payload.</remarks>
	public class Totals
	{
		public double TotalTax { get; set; }

		public double TotalPrice { get; set; }

		public double TotalPayment { get; set; }

		public double TotalToPay { get; set; }
	}
}
