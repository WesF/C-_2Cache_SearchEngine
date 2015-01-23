using System;
using OOP5.Provided;
using System.TimeSpan;

namespace OOP5.Solution
{
	public class TimeBoundedQueryCache:IQueryCache
	{
		#region IQueryCache implementation
		public TimeSpan t;

		public System.Collections.Generic.IEnumerable<string> GetQueryResults (IQuery query)
		{
			throw new NotImplementedException ();
		}

		#endregion
		public TimeBoundedQueryCache( TimeSpan t )
		{

		}

		public TimeBoundedQueryCache ()
		{
		}
	}
}

