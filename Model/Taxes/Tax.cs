using System;

using Newtonsoft.Json;

namespace Vend
{
	public class Tax : BaseApiObject
	{
		/// <summary>
		/// Gets or sets a value indicating whether this instance is default.
		/// </summary>
		/// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
		[JsonProperty("default")]
		public int IsDefault { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the rate.
		/// </summary>
		/// <value>The rate.</value>
		[JsonProperty("rate")]
		public double Rate { get; set; }
	}
}
