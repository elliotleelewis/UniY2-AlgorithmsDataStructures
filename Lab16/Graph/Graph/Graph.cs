﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Graph
{
    internal class Graph<T> where T : IComparable
    {
        private readonly LinkedList<GraphNode<T>> _nodes;
        public Graph()
        {
            _nodes = new LinkedList<GraphNode<T>>();
        }
        public bool IsEmptyGraph()
        {
            return _nodes.Count == 0;
        }
        public bool ContainsGraph(GraphNode<T> node)
        {
            return _nodes.Any(n => n.Id.CompareTo(node.Id) == 0);
        }
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            return from.GetAdjList().Any(id => id.CompareTo(to.Id) == 0);
        }
        public void AddNode(T id)
        {
            _nodes.AddFirst(new GraphNode<T>(id));
        }
        public GraphNode<T> GetNodeById(T id)
        {
            return _nodes.FirstOrDefault(node => node.Id.CompareTo(id) == 0);
        }
        public void AddEdge(T from, T to)
        {
            var fromNode = GetNodeById(from);
            var toNode = GetNodeById(to);
            if(!IsAdjacent(fromNode, toNode))
                fromNode.AddEdge(toNode);
        }
        public void DepthFirstTraverse(T startId, ref List<T> visited)
        {
            var toVisit = new Stack<T>();
            toVisit.Push(startId);
            while (toVisit.Count != 0) {
                var current = GetNodeById(toVisit.Pop());
                visited.Add(current.Id);
                foreach (var node in current.GetAdjList()) {
                    if (!visited.Contains(node) && !toVisit.Contains(node))
                    {
                        toVisit.Push(node);
                    }
                }
            }
        }
        public void BreadthFirstTraverse(T startId, ref List<T> visited)
        {
            var toVisit = new Queue<T>();
            toVisit.Enqueue(startId);
            while (toVisit.Count != 0)
            {
                var current = GetNodeById(toVisit.Dequeue());
                visited.Add(current.Id);
                foreach (var node in current.GetAdjList())
                {
                    if (!visited.Contains(node) && !toVisit.Contains(node))
                    {
                        toVisit.Enqueue(node);
                    }
                }
            }
        }
    }
}