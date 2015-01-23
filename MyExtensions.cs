namespace OOP5.Solution
{
	using System;
	using OOP5.Provided;
	using System.Collections.Generic;
	using System.Linq;

	public class MyExtensions:ISearchCore, IQueryDataSource
	{
		public MyExtensions ()
		{
		}

		public static IEnumerable<string> Search (this SearchCore s, IQuery q)
		{
			//Accept a query and return IEnumerable<string> of all document IDs matching that query

			if (q.Operator == QueryOperator.Any) 
			{

				var GetAnyMatch = 
					from single_query in q.Terms
						group s.Search(single_query) by s.documents.Keys into results
						where results.Count >= 1
						select results[0];
				return GetAnyMatch;

			}


			if (q.Operator == QueryOperator.All) 
			{

					

					var GetAllMatch = 
					from single_query in q.Terms
					group s.Search(single_query) by s.documents.Keys into results
					where results.Count >= q.Terms.Length
					select results[0];

				return GetAllMatch;


			}
		}

		#region IQueryDataSource implementation

		public event OOP5.Provided.CacheInvalidateDelegate ;

		public CacheMissHandler CacheMissHandler {
			get;
		}

		#endregion

		#region ISearchCore implementation

		public event OOP5.Provided.CacheInvalidateDelegate ;

		public void IndexDocument (Document doc)
		{
			throw new NotImplementedException ();
		}

		public IEnumerable<string> Search (string term)
		{
			throw new NotImplementedException ();
		}

		public Document this [string id] {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion

		public IQueryDataSource AsQueryDataSource ()
		{

		}

}

