using System;
namespace Assignment
{
    public class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }
        public void InsertItem(T item)
        {
            _insertItem(item, ref root);
        }
        private static void _insertItem(T item, ref Node<T> tree)
        {
            if(tree == null)
                tree = new Node<T>(item);
            else if(item.CompareTo(tree.Data) < 0)
                _insertItem(item, ref tree.Left);
            else if(item.CompareTo(tree.Data) > 0)
                _insertItem(item, ref tree.Right);
        }
        public int Height()
        {
            return _height(root);
        }
        protected int _height(Node<T> tree)
        {
            if(tree == null) {
                return 0;
            }
            return 1 + Math.Max(_height(tree.Left), _height(tree.Right));
        }
        public bool Contains(T item)
        {
            return _contains(root, item);
        }
        private static bool _contains(Node<T> tree, T item)
        {
            if(tree == null) {
                return false;
            }
            if(tree.Data.Equals(item)) {
                return true;
            }
            return _contains(tree.Left, item) || _contains(tree.Right, item);
        }
        public void RemoveItem(T item)
        {
            _removeItem(item, ref root);
        }
        private static void _removeItem(T item, ref Node<T> tree)
        {
            if(tree == null) {
                return;
            }
            if(item.CompareTo(tree.Data) < 0) {
                _removeItem(item, ref tree.Left);
            }
            else if(item.CompareTo(tree.Data) > 0) {
                _removeItem(item, ref tree.Right);
            }
            else if(tree.Left == null) {
                tree = tree.Right;
            }
            else if(tree.Right == null) {
                tree = tree.Left;
            }
            else {
                var newRoot = _leastItem(tree.Right);
                tree.Data = newRoot;
                _removeItem(newRoot, ref tree.Right);
            }
        }
        private static T _leastItem(Node<T> tree)
        {
            return tree.Left == null ? tree.Data : _leastItem(tree.Left);
        }
    }
}