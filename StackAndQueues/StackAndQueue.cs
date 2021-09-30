using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueues
{
    class StackAndQueue
    {
        private Node top;
        public StackAndQueue()
        {
            this.top = null;
        }
        internal void Add(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} Added to stack ", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
