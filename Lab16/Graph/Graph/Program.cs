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
            graph.AddEdge('A', 'C');
            graph.AddEdge('A', 'D');
            graph.AddEdge('B', 'C');
            graph.AddEdge('B', 'E');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('C', 'F');
            graph.AddEdge('D', 'F');
            var visited = new List<char>();
            graph.BreadthFirstTraverse('A', ref visited);
            for (var i = 0; i < visited.Count; i++) {
                Console.WriteLine(visited[i]);
            }
            Console.ReadKey();
        }
    }
}