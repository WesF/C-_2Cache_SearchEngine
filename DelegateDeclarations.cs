using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP5.Provided
{
	/// <summary>
	/// Represents a function which can try to handle a cache miss in a lower-level cache
	/// </summary>
	/// <param name="query">The query which caused the cache miss</param>
	/// <returns>The ids of all the documents that the query returns</returns>
	public delegate IEnumerable<string> CacheMissHandler(IQuery query);

	/// <summary>
	/// Reprsents a function which notifies a lower level cache that the data index has been modified
	/// (and the cache probably wants to invalidate itself)
	/// </summary>
	public delegate void CacheInvalidateDelegate();
}
