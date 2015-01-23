using System;
using OOP5.Provided;
using System.Collections.Generic;

namespace OOP5.Solution
{
	public class SearchWithTwoLevelCache
	{
		public SearchWithTwoLevelCache ()
		{
		}
		public SearchWithTwoLevelCache(ISearchCore s, ICurrentTimeProvider q)
		{
		}

		public IEnumerable<string> Search(IQuery query){}

	}
}

