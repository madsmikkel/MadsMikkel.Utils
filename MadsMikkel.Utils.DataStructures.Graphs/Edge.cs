using System.Runtime.CompilerServices;

#if DEBUG
[assembly: InternalsVisibleTo("MadsMikkel.Utils.DataStructures.Graphs.Tests")]
#endif

namespace MadsMikkel.Utils.DataStructures.Graphs
{
	/// <summary>
	/// Represents an edge in a graph.
	/// </summary>
	/// <typeparam name="TEdge">The type contained within the edge.</typeparam>
	internal class Edge<TEdge>
	{

		#region Fields
		/// <summary>
		/// The content of this edge.
		/// </summary>
		protected TEdge content;
		#endregion


		#region Constructors
		/// <summary>
		/// Initializes a new instance of this type with the specified content.
		/// </summary>
		/// <param name="content">The content to be contained within the edge.</param>
		public Edge(TEdge content)
		{
			Content = content;
		}
		#endregion


		#region Methods
		public override string ToString() => $"\tEdge content: {content}\n";
		#endregion


		#region Properties
		/// <summary>
		/// Gets or sets the content within the edge.
		/// </summary>
		public TEdge Content
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
		#endregion
	}
}