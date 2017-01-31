using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinarySearchTree
{
    internal class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            _insertItem(item, ref root);
        }
        private void _insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                _insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                _insertItem(item, ref tree.Right);
            tree.BalanceFactor = _height(tree.Left) - _height(tree.Right);
            if (tree.BalanceFactor <= -2)
                _rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                _rotateRight(ref tree);
        }
        private void _rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
                _rotateRight(ref tree.Right);
            var oldRoot = tree;
            var newRoot = tree.Right;
            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;
            tree = newRoot;
        }
        private void _rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
                _rotateLeft(ref tree.Left);
            var oldRoot = tree;
            var newRoot = tree.Left;
            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;
            tree = newRoot;
        }
    }
}