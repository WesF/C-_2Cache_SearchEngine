using System;
using System.Collections.Generic;
namespace OOP5.Provided
{
	/// <summary>
	/// Represents a basic Search Core.
	/// Needs to be extended without modifing this file.
	/// </summary>
	public interface ISearchCore
	{
		/// <summary>
		/// Adds a document to the index. Must raise the ReIndexed event.
		/// </summary>
		/// <param name="doc">The document to index</param>
		void IndexDocument(Document doc);

		/// <summary>
		/// Search the index for all the documents which contain the search term
		/// </summary>
		/// <param name="term">A signle search term</param>
		/// <returns>The ids of all the documents that contain the search term</returns>
		IEnumerable<string> Search(string term);

		/// <summary>
		/// Return a document by Id
		/// </summary>
		/// <param name="id">the document id</param>
		/// <returns>the document with the given id</returns>
		Document this[string id]
		{
			get;
		}

		/// <summary>
		/// An even which should be raised when there is change in the index
		/// </summary>
		event CacheInvalidateDelegate ReIndexed;

		IQueryDataSource AsQueryDataSource();
	}
}
