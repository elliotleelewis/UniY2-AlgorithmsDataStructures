using System;
namespace Assignment
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
        private static void _inOrder(Node<T> tree, ref string buffer)
        {
            while(true) {
                if(tree == null) return;
                _inOrder(tree.Left, ref buffer);
                buffer += tree.Data + " ";
                tree = tree.Right;
            }
        }
        public string PreOrder()
        {
            var str = "";
            _preOrder(root, ref str);
            return str;
        }
        private static void _preOrder(Node<T> tree, ref string buffer)
        {
            while(true) {
                if(tree == null) return;
                buffer += tree.Data + " ";
                _preOrder(tree.Left, ref buffer);
                tree = tree.Right;
            }
        }
        public string PostOrder()
        {
            var str = "";
            _postOrder(root, ref str);
            return str;
        }
        private static void _postOrder(Node<T> tree, ref string buffer)
        {
            if(tree == null) return;
            _postOrder(tree.Left, ref buffer);
            _postOrder(tree.Right, ref buffer);
            buffer += tree.Data + " ";
        }
        public void Copy(BinTree<T> tree2)
        {
            _copy(ref root, tree2.root);
        }
        private static void _copy(ref Node<T> tree, Node<T> tree2)
        {
            tree = new Node<T>(tree2.Data);
            if(tree2.Left != null)
                _copy(ref tree.Left, tree2.Left);
            if(tree2.Right != null)
                _copy(ref tree.Right, tree2.Right);
        }
        public int Count()
        {
            var i = 0;
            _count(ref root, ref i);
            return i;
        }
        private static void _count(ref Node<T> tree, ref int i)
        {
            if(tree == null) return;
            i++;
            _count(ref tree.Left, ref i);
            _count(ref tree.Right, ref i);
        }
    }
}