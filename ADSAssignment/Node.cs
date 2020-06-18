using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSAssignment
{
    public class Node<T> where T : IComparable
    {
        private T data;
        public Node<T> Left, Right;

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }

        private int balanceFactor = 0;
        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }
    }
}
