using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
#if DEBUG
[assembly: InternalsVisibleTo("MadsMikkel.Utils.DataStructures.Graphs.Tests")]
#endif

namespace MadsMikkel.Utils.DataStructures.Graphs
{

	/// <summary>
	/// Represents a vertex in a graph.
	/// </summary>
	/// <typeparam name="TVertex">The type contained within the vertex.</typeparam>
	/// <typeparam name="TEdge">The type contained within the edges.</typeparam>
	internal class Vertex<TVertex, TEdge>
	{
		#region Fields
		/// <summary>
		/// The content of this vertex.
		/// </summary>
		protected TVertex content;

		/// <summary>
		/// The list of edges associated with this vertex.
		/// </summary>
		protected List<Edge<TEdge>> edges;

		/// <summary>
		/// The list of vertices connected to this vertex.
		/// </summary>
		protected List<Vertex<TVertex, TEdge>> neighbors;
		#endregion


		#region Constructors
		/// <summary>
		/// Initializes a new instance of this type with the specified content.
		/// </summary>
		/// <param name="content">The content to be contained within the vertex.</param>
		internal Vertex(TVertex content) : this(content, null) { }

		/// <summary>
		/// Initializes a new instance of this type with the specified content.
		/// </summary>
		/// <param name="content"></param>
		/// <param name="neighbors"></param>
		internal Vertex(TVertex content, List<Vertex<TVertex, TEdge>> neighbors)
			: this(content, neighbors, null) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="content"></param>
		/// <param name="neighbors"></param>
		/// <param name="edges"></param>
		internal Vertex(
			TVertex content,
			List<Vertex<TVertex, TEdge>> neighbors,
			List<Edge<TEdge>> edges)
		{
			this.content = content;
			this.neighbors = neighbors ?? new List<Vertex<TVertex, TEdge>>(0);
			this.edges = edges ?? new List<Edge<TEdge>>(0);
		}
		#endregion


		#region Methods
		/// <summary>
		/// Add a new edge to the specified neighbor.
		/// </summary>
		/// <param name="edge">The edge add.</param>
		/// <param name="toNeighbor">The neighbor to be associated with this vertex, 
		///		via the specified edge.</param>
		/// <exception cref="ArgumentNullException"></exception>
		internal virtual void Add(Edge<TEdge> edge, Vertex<TVertex, TEdge> toNeighbor)
		{
			if(edge != null && toNeighbor != null)
			{
				edges.Add(edge);
				try
				{
					Add(toNeighbor);

				}
				catch(ArgumentNullException) { throw; }
			}
			else throw new ArgumentNullException("An edge is not allowed to be null.");
		}

		/// <summary>
		/// Add a new neighbor to the list of neighbors.
		/// </summary>
		/// <param name="neighbor">The neighbor to add.</param>
		/// <exception cref="ArgumentNullException"></exception>
		protected virtual void Add(Vertex<TVertex, TEdge> neighbor)
		{
			if(neighbor != null)
				if(!neighbors.Contains(neighbor))
					neighbors.Add(neighbor);
				else throw new ArgumentNullException("A vertex is not allowed to be null.");
		}

		public override bool Equals(object obj) => base.Equals(obj) && ReferenceEquals(this, obj);


		internal virtual void Remove(Edge<TEdge> edge)
		{
			edges.Remove(edge);
		}

		internal virtual void Remove(Vertex<TVertex, TEdge> neighbor)
		{
			neighbors.Remove(neighbor);
		}


		public override string ToString()
		{
			string s =
				$"Vertex:" +
				$"\tContent: {content}" +
				$"\tNeighbors: {neighbors.Count}" +
				$"\tEdges: {edges.Count}";
			foreach(Edge<TEdge> edge in edges)
				s += $"\t{edge.ToString()}";
			return s;
		}
		#endregion


		#region Properties
		/// <summary>
		/// Gets or sets the content within the vertex.
		/// </summary>
		public virtual TVertex Content
		{
			get
			{
				return content;
			}
			set
			{
				content = value;
			}
		}

		/// <summary>
		/// Get or sets the list of edges associated with this vertex.
		/// </summary>
		internal virtual List<Edge<TEdge>> Edges
		{
			get
			{
				return edges;
			}

			set
			{
				edges = value;
			}
		}

		/// <summary>
		/// Get or sets the list of neighboring associated with this vertex.
		/// </summary>
		internal virtual List<Vertex<TVertex, TEdge>> Neighbors
		{
			get
			{
				return neighbors;
			}

			set
			{
				neighbors = value;
			}
		}
		#endregion
	}
}