using System;
namespace Assignment
{
    internal class Node<T> where T : IComparable
    {
        public Node<T> Left, Right;
        public Node(T item)
        {
            Data = item;
            Left = null;
            Right = null;
        }
        public T Data { set; get; }
        public int BalanceFactor { set; get; }
    }
}