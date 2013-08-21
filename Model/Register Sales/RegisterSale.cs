using System.Collections.Generic;

namespace Vend
{
	/// <summary>
	/// Register sale.
	/// </summary>
	public class RegisterSale : BaseApiObject
	{
		public virtual string RegisterId { get; set; }
			    
		public virtual string MarketId { get; set; }
			    
		public virtual string CustomerId { get; set; }
			    
		public virtual string CustomerName { get; set; }
			    
		public virtual Customer Customer { get; set; }
			    
		public virtual string UserId { get; set; }
			    
		public virtual string UserName { get; set; }
			    
		public virtual string SaleDate { get; set; }
			    
		public virtual string CreatedAt { get; set; }
			    
		public virtual string UpdatedAt { get; set; }
			    
		public virtual double TotalPrice { get; set; }
			    
		public virtual int TotalCost { get; set; }
			    
		public virtual double TotalTax { get; set; }
			    
		public virtual string TaxName { get; set; }
			    
		public virtual string Note { get; set; }
			    
		public virtual string Status { get; set; }
			    
		public virtual string ShortCode { get; set; }
			    
		public virtual string InvoiceNumber { get; set; }
			    
		public virtual List<string> RegisterSaleProducts { get; set; }
			    
		public virtual Totals Totals { get; set; }

		public virtual List<string> RegisterSalePayments { get; set; }
	}
}
