using System.Collections.Generic;

using Newtonsoft.Json;

namespace Vend
{
	/// <summary>
	/// Register sale.
	/// </summary>
	public class RegisterSale : BaseApiObject
	{
		[JsonProperty("register_id")]
		public virtual string RegisterId { get; set; }
			    
		[JsonProperty("market_id")]
		public virtual string MarketId { get; set; }
			    
		[JsonProperty("customer_id")]
		public virtual string CustomerId { get; set; }
			    
		[JsonProperty("customer_name")]
		public virtual string CustomerName { get; set; }
			    
		[JsonProperty("customer")]
		public virtual Customer Customer { get; set; }
			    
		[JsonProperty("user_id")]
		public virtual string UserId { get; set; }
			    
		[JsonProperty("user_name")]
		public virtual string UserName { get; set; }
			    
		[JsonProperty("sale_date")]
		public virtual string SaleDate { get; set; }
			    
		[JsonProperty("created_at")]
		public virtual string CreatedAt { get; set; }
			    
		[JsonProperty("updated_at")]
		public virtual string UpdatedAt { get; set; }
			    
		[JsonProperty("total_price")]
		public virtual double TotalPrice { get; set; }
			    
		[JsonProperty("total_cost")]
		public virtual int TotalCost { get; set; }
			    
		[JsonProperty("total_tax")]
		public virtual double TotalTax { get; set; }
			    
		[JsonProperty("tax_name")]
		public virtual string TaxName { get; set; }
			    
		[JsonProperty("note")]
		public virtual string Note { get; set; }
			    
		[JsonProperty("status")]
		public virtual string Status { get; set; }
			    
		[JsonProperty("short_code")]
		public virtual string ShortCode { get; set; }
			    
		[JsonProperty("invoice_number")]
		public virtual string InvoiceNumber { get; set; }
			    
		[JsonProperty("register_sale_products")]
		public virtual List<RegisterSaleProduct> RegisterSaleProducts { get; set; }
			    
		[JsonProperty("totals")]
		public virtual Totals Totals { get; set; }

		[JsonProperty("register_sale_payments")]
		public virtual List<RegisterSalePayment> RegisterSalePayments { get; set; }
	}
}
