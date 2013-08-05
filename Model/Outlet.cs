using System;

namespace Vend
{
	/// <summary>
	/// Outlet.
	/// </summary>
	public class Outlet : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the time zone.
		/// </summary>
		/// <value>The time zone.</value>
		public string TimeZone { get; set; }
	}
}

