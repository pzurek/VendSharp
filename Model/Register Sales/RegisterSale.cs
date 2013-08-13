using System.Collections.Generic;

namespace Vend
{
	/// <summary>
	/// Register sale.
	/// </summary>
	public class RegisterSale : BaseApiObject
	{
		public string RegisterId { get; set; }

		public string MarketId { get; set; }

		public string CustomerId { get; set; }

		public string CustomerName { get; set; }

		public Customer Customer { get; set; }

		public string UserId { get; set; }

		public string UserName { get; set; }

		public string SaleDate { get; set; }

		public string CreatedAt { get; set; }

		public string UpdatedAt { get; set; }

		public double TotalPrice { get; set; }

		public int TotalCost { get; set; }

		public double TotalTax { get; set; }

		public string TaxName { get; set; }

		public string Note { get; set; }

		public string Status { get; set; }

		public string ShortCode { get; set; }

		public string InvoiceNumber { get; set; }

		public List<string> RegisterSaleProducts { get; set; }

		public Totals Totals { get; set; }

		public List<string> RegisterSalePayments { get; set; }
	}
}
