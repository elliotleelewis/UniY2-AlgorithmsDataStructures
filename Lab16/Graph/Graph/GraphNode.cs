using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class GraphNode<T>
    {
        private readonly LinkedList<T> _adjList;
        public GraphNode(T id)
        {
            this.Id = id;
            _adjList = new LinkedList<T>();
        }
        public T Id { get; set; }
        public void AddEdge(GraphNode<T> to)
        {
            _adjList.AddFirst(to.Id);
        }
        public LinkedList<T> GetAdjList()
        {
            return _adjList;
        }
    }
}
