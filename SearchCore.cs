using System;
using System.Collections;
using OOP5.Provided;

namespace OOP5.Solution
{

	public delegate void CacheInvalidateDelegate(object sender, EventArgs e);

	public class SearchCore : OOP5.Provided.ISearchCore
	{
		private static readonly char[] delimiters = new char[] { ' ', '\r', '\n', '\t' };
		event CacheInvalidateDelegate ReIndexed;

		public Hashtable documents = new Hashtable();

		public virtual void OnUpdate (EventArgs e)
		{
			if( ReIndexed != null)
				ReIndexed(this,e);
		}
		#region ISearchCore implementation

		public event OOP5.Provided.CacheInvalidateDelegate ;

		public void IndexDocument (OOP5.Provided.Document doc)
		{
			//Check type of document
			if (! OOP5.Provided.Document.Equals (doc))
		 		throw new NotImplementedException ();
			//If document ID already exists, throw exception
			if (documents.ContainsKey(doc.Id))
				throw new ArgumentException ();
			else
			{
				documents.Add(doc.Id,doc);
				OnUpdate(EventArgs.Empty);
			}
		}

		public System.Collections.Generic.IEnumerable<string> Search (string term)
		{
			//if()
				throw new NotImplementedException ();

			foreach(DictionaryEntry entry in documents)
			{

				string[] terms = entry.Value.Contents.Split(delimiters);
				if(Array.Exists(terms,term))
				{
					yield return entry.Key;

				}

			}
		}

		public OOP5.Provided.Document this [string id] {
			get 
			{
				return documents[id];
			}



		}

		#endregion

		public SearchCore ()
		{
		}
	}
}

