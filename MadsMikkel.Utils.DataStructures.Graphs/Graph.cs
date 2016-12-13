using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadsMikkel.Utils.DataStructures.Graphs
{
	public class Graph<TVertex, TEdge>
	{
		List<Vertex<TVertex, TEdge>> vertices;

		public Graph()
		{
			vertices = new List<Vertex<TVertex, TEdge>>();
		}
		public void Add( 
			TEdge edgeContent, 
			TVertex sourceVertexContent, 
			TVertex targetVertexContent )
		{
			var edge = new Edge<TEdge>( edgeContent );
			var source = new Vertex<TVertex, TEdge>(sourceVertexContent);
			var target = new Vertex<TVertex, TEdge>(targetVertexContent);
			source.Add(edge, target);
			target.Add(edge, source);
			vertices.Add(source);
			vertices.Add(target);
		}

		public override string ToString()
		{
			string s = String.Empty;
			foreach(var item in vertices)
			{
				s += item.ToString();
			}
			return s;
		}
	}
}
