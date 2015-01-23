using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OOP5.Provided
{
	/// <summary>
	/// An interface which represents a query
	/// </summary>
	public interface IQuery
	{
		/// <summary>
		/// The terms of the query. Each string must contain a single term.
		/// </summary>
		string[] Terms { get; }

		/// <summary>
		/// The search operator (either All or Any)
		/// </summary>
		QueryOperator Operator { get; }
	}

	/// <summary>
	/// Utilities for indexing and searching
	/// </summary>
	public static class QueryUtils
	{
		/// <summary>
		/// Splits a string which contains any number of terms into the terms it contains. 
		/// Also cleans the terms from non-alphanumeric characters
		/// </summary>
		/// <param name="s">The string to split</param>
		/// <returns>The terms which the string contains, in the order in which they appeared, with duplicates</returns>
		public static string[] GetTermsFromString(string s)
		{
			return s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(x => CleanString(x)).ToArray();
		}

		private static string CleanString(string s)
		{
			return cleanRegex.Replace(s, "");
		}

		private static readonly char[] delimiters = new char[] { ' ', '\r', '\n', '\t' };
		private static readonly Regex cleanRegex = new Regex(@"\A");
	}

	public enum QueryOperator { Any, All };
}
