using System;
using System.Collections.Generic;
using System.Text;

namespace Binarytree
{
    class Node<Gtype>
    {
        private int data;
        private Node<Gtype> pre;
        private Node<Gtype> next;
        public Node(int data)
        {
            this.pre = null;
            this.data = data;
            this.next = null;
        }
        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public Node<Gtype> Pre
        {
            get { return this.pre; }
            set { this.pre = value; }
        }
        public Node<Gtype> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
