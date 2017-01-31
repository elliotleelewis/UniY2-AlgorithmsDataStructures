using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinarySearchTree
{
    internal class BinTree<T> where T : IComparable
    {
        protected Node<T> root;
        public BinTree()
        {
            root = null;
        }
        public BinTree(Node<T> node)
        {
            root = node;
        }
        public string InOrder()
        {
            var str = "";
            _inOrder(root, ref str);
            return str;
        }
        private void _inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null) {
                _inOrder(tree.Left, ref buffer);
                buffer += tree.Data + " ";
                _inOrder(tree.Right, ref buffer);
            }
        }
        public string PreOrder()
        {
            var str = "";
            _preOrder(root, ref str);
            return str;
        }
        private void _preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null) {
                buffer += tree.Data + " ";
                _preOrder(tree.Left, ref buffer);
                _preOrder(tree.Right, ref buffer);
            }
        }
        public string PostOrder()
        {
            var str = "";
            _postOrder(root, ref str);
            return str;
        }
        private void _postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null) {
                _postOrder(tree.Left, ref buffer);
                _postOrder(tree.Right, ref buffer);
                buffer += tree.Data + " ";
            }
        }
        public void Copy(BinTree<T> tree2)
        {
            copy(ref root, tree2.root);
        }
        private void copy(ref Node<T> tree, Node<T> tree2)
        {
            tree = new Node<T>(tree2.Data);
            if (tree2.Left != null)
                copy(ref tree.Left, tree2.Left);
            if (tree2.Right != null)
                copy(ref tree.Right, tree2.Right);
        }
        public int Count()
        {
            var i = 0;
            _count(ref root, ref i);
            return i;
        }
        private void _count(ref Node<T> tree, ref int i)
        {
            if (tree != null) {
                i++;
                _count(ref tree.Left, ref i);
                _count(ref tree.Right, ref i);
            }
        }
    }
}