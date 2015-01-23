using System;
using OOP5.Provided;
using System.Collections.Generic;
namespace OOP5.Provided
{
	/// <summary>
	/// A bundle which contains a SearchCore and 2 levels of Cache
	/// </summary>
	public abstract class AbstactSearchWithTwoLevelCache
	{
		/// <summary>
		/// The lower (closer to the client) cache
		/// </summary>
		protected abstract IQueryCache Level1Cache { get; }

		/// <summary>
		/// The higher (closer to the SearchCore) cache
		/// </summary>
		protected abstract IQueryCache Level2Cache { get; }

		/// <summary>
		/// The Search Core
		/// </summary>
		protected abstract ISearchCore SearchCore { get; }

		/// <summary>
		/// Search the search core & cache structure for the given query
		/// </summary>
		/// <param name="query">the query to search</param>
		/// <returns>the results for the query</returns>
		public abstract IEnumerable<string> Search(IQuery query);
	}
}
