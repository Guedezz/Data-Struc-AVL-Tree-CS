﻿using System;

namespace ADSAssignment
{
    public class BinTree<T> where T : IComparable
    {
        protected Node<T> root;
        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            InOrder(root, ref buffer);
        }

        private void InOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                InOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                InOrder(tree.Right, ref buffer);
            }
        }

        public void PreOrder(ref string buffer)
        {
            PreOrder(root, ref buffer);
        }

        private void PreOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                InOrder(tree.Left, ref buffer);
                InOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            PostOrder(root, ref buffer);
        }

        private void PostOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                InOrder(tree.Left, ref buffer);
                InOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }

        }
    }
}
