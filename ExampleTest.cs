using OOP5.Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOP5.Provided;
using System.Collections.Generic;
using System.Linq;

namespace OOP5.Tests
{
    
    
    /// <summary>
    ///This is a test class for SearchWithTwoLevelCacheTest and is intended
    ///to contain all SearchWithTwoLevelCacheTest Unit Tests
    ///</summary>
	[TestClass()]
	public class ExampleTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for Search
		///</summary>
		[TestMethod()]
		public void SearchTest()
		{
			ISearchCore searchCore = new SearchCore();
			ICurrentTimeProvider timeProvider = new NowCurrentTimeProvider();
			SearchWithTwoLevelCache target = new SearchWithTwoLevelCache(searchCore, timeProvider);
			Document doc1 = new Document("doc1", "This is a document");
			Document doc2 = new Document("doc2", "This is some text");
			searchCore.IndexDocument(doc1);
			searchCore.IndexDocument(doc2);
			IQuery query = new Query("document text", QueryOperator.Any);
			IEnumerable<string> expected = new List<string>() { doc1.Id, doc2.Id };
			IEnumerable<string> actual = target.Search(query);
			Assert.AreEqual(0, expected.Except(actual).Count());
			Assert.AreEqual(0, actual.Except(expected).Count());
			Assert.AreEqual(doc1.Contents, searchCore[doc1.Id].Contents);
		}

		[TestMethod()]
		public void DateTimeExample()
		{
			DateTime now = DateTime.Now;
			TimeSpan two_and_a_half_days = TimeSpan.FromDays(2.5);
			DateTime two_and_a_half_days_from_now = now.Add(two_and_a_half_days);
			DateTime two_and_a_half_days_ago = now.Subtract(two_and_a_half_days);
			Console.WriteLine(now);
			Console.WriteLine(two_and_a_half_days_from_now);
			Console.WriteLine(two_and_a_half_days_ago);
		}

		private class NowCurrentTimeProvider : ICurrentTimeProvider
		{
			public DateTime Now
			{
				get { return DateTime.Now; }
			}
		}

	}
}
