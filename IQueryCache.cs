using System;
using System.Collections.Generic;
namespace OOP5.Provided
{
	/// <summary>
	/// Represents a Query Cache
	/// </summary>
	public interface IQueryCache : IQueryDataSource
	{
		/// <summary>
		/// Gets the results of a query, either from the cache or a higher level source
		/// </summary>
		/// <param name="query">The query to run</param>
		/// <returns>The ids of all the documents that the query returns</returns>
		IEnumerable<string> GetQueryResults(IQuery query);


	
	}
}
