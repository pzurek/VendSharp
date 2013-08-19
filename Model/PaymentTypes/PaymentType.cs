namespace Vend
{
	public class PaymentType : BaseApiObject
	{
		public string Name { get; set; }
		public string PaymentTypeId { get; set; }
		public PaymentConfig Config { get; set; }
		public PaymentType2 PaymentType2 { get; set; }
	}
}
