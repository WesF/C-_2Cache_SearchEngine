using System;
using OOP5.Provided;

namespace OOP5.Solution
{
	public class SizeBoundedQueryCache: IQueryCache
	{
		#region IQueryCache implementation

		public System.Collections.Generic.IEnumerable<string> GetQueryResults (IQuery query)
		{
			throw new NotImplementedException ();
		}

		#endregion

		public SizeBoundedQueryCache ()
		{
		}
	}
}

