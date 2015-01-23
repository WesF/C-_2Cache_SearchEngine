using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP5.Provided
{
	/// <summary>
	/// A warpper for getting the current time. In a test environment it will return an artificailly generated time.
	/// In a real environment it will return DateTime.Now .
	/// </summary>
	public interface ICurrentTimeProvider
	{
		/// <summary>
		/// Returns the current time
		/// </summary>
		DateTime Now { get; }
	}
}
