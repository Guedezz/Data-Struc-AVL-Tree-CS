using System;

namespace ADSAssignment
{
    public class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
            balanceTree(ref tree);
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
            balanceTree(ref root);
        }

        private void balanceTree(ref Node<T> tree)
        {
            if (tree != null)
            {
                tree.BalanceFactor = height(tree.Left) - height(tree.Right);

                if (tree.BalanceFactor <= -2)
                    rotateLeft(ref tree);
                if (tree.BalanceFactor >= 2)
                    rotateRight(ref tree);
            }
        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
            {
                rotateRight(ref tree.Right);
            }
            Node<T> newRoot = tree.Right;
            tree.Right = tree.Right.Left;
            newRoot.Left = tree;
            tree = newRoot;
        }

        private void rotateRight(ref Node<T> tree)
        {
            Node<T> newRoot = tree.Left;
            tree.Left = tree.Left.Right;
            newRoot.Right = tree;
            tree = newRoot;
        }
    }
}
