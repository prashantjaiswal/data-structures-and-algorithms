﻿using System;
namespace DataStructuresAlgorithms.LinkedList
{
    public class LinkedList<T>
    {
        

        public LinkedList(T value)
        {
            this.head = new Node<T>(value);
            this.tail = this.head;
            this.length = 1;
        }

        public Node<T> head { get; private set; }
        public Node<T> tail { get; private set; }
        public int length { get; private set; }

        public Node<T> Append(T value)
        {
            var newNode = new Node<T>(value);
            this.tail.next = newNode;
            this.tail = newNode;
            this.length += 1;
            return newNode;
        }

        public Node<T> Prepend(T value)
        {
            var newNode = new Node<T>(value);
            newNode.next = this.head;
            this.head = newNode;
            this.length += 1;
            return this.head;
        }
    }
    public class Node<T>
    {
        public T value { get; private set; }

        public object next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
