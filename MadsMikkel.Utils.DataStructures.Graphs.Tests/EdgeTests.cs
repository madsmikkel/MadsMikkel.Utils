using MadsMikkel.Utils.DataStructures.Graphs;
using MadsMikkel.Utils.DataStructures.Graphs.Tests.TestEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MadsMikkel.Utils.DataStructures.Graphs.Tests
{

	/// <summary>
	/// Tests all functionality in the Edge class.
	/// </summary>
	[TestClass]
	class EdgeTests
	{
		/// <summary>
		/// Test whether or not a successful construction of an instance is made.
		/// </summary>
		[TestMethod]
		public void ConstructionSuccess()
		{
			// Arrange:
			Edge<Line> edge;
			Line t = new Line("123");

			// Act:
			edge = new Edge<Line>(t);

			// Assert:
			Assert.IsNotNull(edge);
		}

		/// <summary>
		/// Test whether or not the provided argument is in fact the data in the object.
		/// </summary>
		[TestMethod]
		public void ArgumentIsData()
		{
			// Arrange:		
			Line expected = new Line("123");
			Edge<Line> edge = new Edge<Line>(expected);

			// Act:
			Line actual = edge.Content;

			// Assert:
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test whether or not the provided argument is in fact the data in the object.
		/// </summary>
		[TestMethod]
		public void MutatingProperty()
		{
			// Arrange:		
			Line expected = new Line("123");
			Edge<Line> edge = new Edge<Line>(new Line("321"));

			// Act:
			edge.Content = expected;
			Line actual = edge.Content;

			// Assert:
			Assert.AreEqual(expected, actual);
		}
	}
}