using System;

namespace ADSAssignment
{
    public class BSTree<T> : BinTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public int Height()
        {
            return height(root);
        }

        public int height(Node<T> tree)
        {
            if (tree == null)
                return 0;
            else
                return 1 + Math.Max(height(tree.Left), height(tree.Right));
        }

        public int Count()
        {
            int number = 0;
            count(root, ref number);
            return number;
        }
        private void count(Node<T> tree, ref int number)
        {
            if (tree != null)
            {
                number++;
                count(tree.Right, ref number);
                count(tree.Left, ref number);
            }
        }

        public Boolean Contains(T item)
        {
            Node<T> node = root;
            return contains(ref root, item);
        }

        private Boolean contains(ref Node<T> node, T item)
        {
            if (node == null)
                return false;
            //if (node.Data == item)
            if (item.CompareTo(node.Data) < 0)
                return contains(ref node.Left, item);
            if (item.CompareTo(node.Data) > 0)
                return contains(ref node.Right, item);
            else
            {
                return true;
            }
        }

        protected void removeItem(T item, ref Node<T> tree)
        {
            if (tree != null)
                if (item.CompareTo(tree.Data) == 0)
                    if (tree.Left == null)
                        tree = tree.Right;
                    else if (tree.Right == null)
                        tree = tree.Left;
                    else
                    {
                        T newRoot = leastItem(ref tree.Right);
                        tree.Data = newRoot;
                        removeItem(newRoot, ref tree.Right);
                    }
                else if (item.CompareTo(tree.Data) < 0)
                    removeItem(item, ref tree.Left);
                else
                    removeItem(item, ref tree.Right);
        }

        protected T leastItem(ref Node<T> tree)
        {
            if (tree.Left == null)
                return tree.Data;
            else
                return leastItem(ref tree.Left);
        }
    }
}
