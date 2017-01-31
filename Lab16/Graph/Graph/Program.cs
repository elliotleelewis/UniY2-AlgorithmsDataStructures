using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Graph
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var graph = new Graph<char>();
            graph.AddNode('A');
            graph.AddNode('B');
            graph.AddNode('C');
            graph.AddNode('D');
            graph.AddNode('E');
            graph.AddNode('F');
            graph.AddEdge('A', 'B');
            graph.AddEdge('B', 'C');
            graph.AddEdge('C', 'D');
            graph.AddEdge('A', 'E');
            graph.AddEdge('A', 'F');
            var current = graph.GetNodeById('A');
            var to = graph.GetNodeById('B');
            Console.WriteLine("Is graph empty? Answer: {0}", graph.IsEmptyGraph());
            Console.WriteLine("Does graph contain {0}? Answer: {1}", current.Id, graph.ContainsGraph(current));
            Console.WriteLine("Is node {0} and {1} adjacent? Answer: {2}", current.Id, to.Id, graph.IsAdjacent(current, to));
            Console.WriteLine("Is node {0} and {1} adjacent? Answer: {2}", to.Id, current.Id, graph.IsAdjacent(to, current));
            Console.ReadKey();
        }
    }
}