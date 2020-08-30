﻿using System;
namespace DataStructuresAlgorithms.StacksQueues
{
    public class Stacks<T>
    {
        public Node<T> top { get; private set; }
        public Node<T> bottom { get; private set; }
        public int length { get; private set; }

        public Stacks()
        {
            this.top = null;
            this.bottom = null;
            this.length = 0;
        }

        public Node<T> Peek()
        {
            return this.top;
        }

        public Node<T> Push(T value)
        {
            var node = new Node<T>(value);
            
            if (this.length == 0)
                this.bottom = node;
            node.next = this.top;
            this.top = node;
            this.length += 1;
            return node;
        }

        public Node<T> Pop()
        {
            if(length > 0)
            {
                var nextNode = this.top.next;
                var popped = this.top;
                this.length -= 1;
                this.top = nextNode;
                return popped;
            }
            return default;
        }

        public bool IsEmpty()
        {
            return this.length == 0;
        }
    }

    public class Node<T>
    {
        public Node(T value)
        {
            this.next = null;
            this.value = value;
        }

        public Node<T> next { get; set; }
        public T value { get; private set; }
    }
}
