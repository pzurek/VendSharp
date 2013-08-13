namespace Vend
{
	public class RegisterSalePayment : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the payment type identifier.
		/// </summary>
		/// <value>The payment type identifier.</value>
		public string PaymentTypeId { get; set; }

		/// <summary>
		/// Gets or sets the register identifier.
		/// </summary>
		/// <value>The register identifier.</value>
		public string RegisterId { get; set; }

		/// <summary>
		/// Gets or sets the retailer payment type identifier.
		/// </summary>
		/// <value>The retailer payment type identifier.</value>
		public string RetailerPaymentTypeId { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
		public string Label { get; set; }

		/// <summary>
		/// Gets or sets the payment date.
		/// </summary>
		/// <value>The payment date.</value>
		public string PaymentDate { get; set; }

		/// <summary>
		/// Gets or sets the amount.
		/// </summary>
		/// <value>The amount.</value>
		public double Amount { get; set; }
	}
}
