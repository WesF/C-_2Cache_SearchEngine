using System;


namespace OOP5.Solution
{
	public class Query: OOP5.Provided.IQuery
	{	

		private string[] terms;


		#region IQuery implementation

		public string[] Terms {
				get { return terms;}
			    set { terms = value;}

		}

		public OOP5.Provided.QueryOperator Operator {

			get {return OOP5.Provided.QueryOperator;}
			set {Operator = value;}
		}

		#endregion

		public Query ()
		{
		}
		public Query (string queryString, OOP5.Provided.QueryOperator op)
		{
			//Access and set the terms array
			this.Terms = OOP5.Provided.QueryUtils.GetTermsFromString(queryString);
			this.Operator = op; 
		}
	}
}

