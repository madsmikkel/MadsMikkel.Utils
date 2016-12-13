//using MadsMikkel.Utils.DataStructures.Graphs;
//using MadsMikkel.Utils.DataStructures.Graphs.Tests.TestEntities;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace MadsMikkel.Utils.DataStructures.Graphs.Tests
//{

//	/// <summary>
//	/// Tests all functionality in the Edge class.
//	/// </summary>
//	[TestClass]
//	class VertexTests
//	{
//		/// <summary>
//		/// Test whether or not a successful construction of an instance is made.
//		/// </summary>
//		[TestMethod]
//		public void ConstructionSuccess()
//		{
//			// Arrange:
//			Vertex<Train> vertex;
//			Train t = new Train( "123" );

//			// Act:
//			vertex = new Vertex<Train>( t );

//			// Assert:
//			Assert.IsNotNull( vertex );
//		}

//		/// <summary>
//		/// Test whether or not the provided argument is in fact the data in the object.
//		/// </summary>
//		[TestMethod]
//		public void ArgumentIsData()
//		{
//			// Arrange:		
//			Train expected = new Train( "123" );
//			Vertex<Train> vertex = new Vertex<Train>( expected );

//			// Act:
//			Train actual = vertex.Content;

//			// Assert:
//			Assert.AreEqual( expected, actual );
//		}

//		/// <summary>
//		/// Test whether or not the provided argument is in fact the data in the object.
//		/// </summary>
//		[TestMethod]
//		public void MutatingProperty()
//		{
//			// Arrange:		
//			Train expected = new Train( "123" );
//			Vertex<Train> vertex = new Vertex<Train>( new Train( "321" ) );

//			// Act:
//			vertex.Content = expected;
//			Train actual = vertex.Content;

//			// Assert:
//			Assert.AreEqual( expected, actual );
//		}
//	}
//}