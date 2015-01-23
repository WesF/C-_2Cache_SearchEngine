using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP5.Provided
{
	/// <summary>
	/// Represents a data source for queries
	/// </summary>
	public interface IQueryDataSource
	{
		/// <summary>
		/// An event which should be raised when there is change in the index
		/// </summary>
		event CacheInvalidateDelegate CacheInvalidated;

		/// <summary>
		/// A delegate which handles cache misses in a lower level cache
		/// </summary>
		CacheMissHandler CacheMissHandler { get; }
	}
}
