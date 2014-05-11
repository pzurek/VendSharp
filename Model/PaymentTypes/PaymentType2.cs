using Newtonsoft.Json;

namespace Vend
{
	public class PaymentType2
	{
		[JsonProperty("native_app")]
		public bool NativeApp { get; set; }
	}
}
