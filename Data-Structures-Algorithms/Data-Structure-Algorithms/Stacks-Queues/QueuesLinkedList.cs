using System;
using DataStructuresAlgorithms.StacksQueues.Structure;

namespace DataStructuresAlgorithms.StacksQueues
{
    public class QueuesLinkedList<T>
    {
        public Node<T> first { get; set; }
        public Node<T> last { get; set; }
        public int length { get; set; }

        public QueuesLinkedList()
        {
            this.first = null;
            this.last = null;
            this.length = 0;

        }

        public Node<T> Peek()
        {
            return this.last;
        }

        public Node<T> Enqueue(T value)
        {
            var newNode = new Node<T>(value);
            if(this.first == default)
            {
                this.first = newNode;
            }
            else
            {
                this.last.next = newNode;
            }
            this.length += 1;
            this.last = newNode;

            return newNode;
        }

        public Node<T> Deqeue()
        {
            var nodeDequeued = this.first;
            if(this.first != null)
            {
                var nextToFirstNode = this.first.next;
                this.first = nextToFirstNode;
                this.length -= 1;
            }
            return nodeDequeued;
        }
    }
}
