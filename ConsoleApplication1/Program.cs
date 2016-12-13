using MadsMikkel.Utils.DataStructures.Graphs;
using MadsMikkel.Utils.DataStructures.Graphs.Tests.TestEntities;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("GRAPH TEST\n\n");
			Graph<Station, Line> graph = new Graph<Station, Line>();
			var line = new Line("7");
			var vj = new Station("Vejle");
			var hs = new Station("Hs");
			graph.Add(line, vj, hs);
			string s;

			s = graph.ToString();


			
			System.Console.WriteLine(s);
			System.Console.ReadLine();
		}
	}
}
