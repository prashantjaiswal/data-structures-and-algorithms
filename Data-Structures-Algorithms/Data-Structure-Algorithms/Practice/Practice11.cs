using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice11
    {
        public class Node
        {
            public int Value { private set; get; }
            public Node Next { set; get; }
            public Node(int val, Node next = null)
            {
                Value = val;
                Next = next;
            }
        }

        static int length = 0;
        static Node head = null;

        public static void insert_node(int position, int value)
        {
            // @params position, integer
            // @params value, integer
            if (position > length + 1)
                return;

            Node tempNode = new Node(value);
            if (head == null || position == 1)
            {
                tempNode.Next = head;
                head = tempNode;
            }
            else
            {
                int counter = 1;
                Node current = head;
                while (counter < (position - 1))
                {
                    current = current.Next;
                    counter += 1;
                }
                tempNode.Next = current.Next;
                current.Next = tempNode;
            }
            length += 1;
        }

        public static void delete_node(int position)
        {
            // @params position, integer
            if (position > length)
            {
                return;
            }
            if (position == 1)
            {
                head = head.Next;
            }
            else
            {
                Node curr = head;
                int counter = 1;
                while (counter < (position - 1))
                {
                    counter += 1;
                    curr = curr.Next;
                }
                curr.Next = curr.Next.Next;
            }
            length -= 1;
        }

        public static void print_ll()
        {
            // Output each element followed by a space
            Node tempNode = head;
            if (tempNode == null)
                return;
            while (tempNode.Next != null)
            {
                Console.Write(tempNode.Value + " ");
                tempNode = tempNode.Next;
            }
            if (tempNode != null)
                Console.Write(tempNode.Value);
        }
    }

    public class NestedIterator
    {
        public List<int> flattenList = null;
        public int current = 0;
       public NestedIterator(List<NestedInteger> nestedList)
        {
            flattenList = new List<int>();
            foreach (NestedInteger element in nestedList)
            {
                helper(element);
            }
        }

        public int next()
        {
            return flattenList[current++];
        }

        public bool hasNext()
        {
            return current < flattenList.Count;
        }

        private void helper(NestedInteger value)
        {
            if (value.IsInteger())
            {
                flattenList.Add(value.GetInteger());
            }
            else
            {
                foreach (NestedInteger integer in value.GetList())
                {
                    helper(integer);
                }
            }
        }
    }

    public interface NestedInteger
    {
 
      // @return true if this NestedInteger holds a single integer, rather than a nested list.
      bool IsInteger();
 
      // @return the single integer that this NestedInteger holds, if it holds a single integer
      // Return null if this NestedInteger holds a nested list
      int GetInteger();
 
      // @return the nested list that this NestedInteger holds, if it holds a nested list
      // Return null if this NestedInteger holds a single integer
      IList<NestedInteger> GetList();
  }

    public class StackProblem
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> minStack = new Stack<int>();
        int min = int.MaxValue;
        public void push(int x)
        {
            if (min > x)
            {
                min = x;
            }
            stack.Push(x);
            minStack.Push(min);
        }

        public void pop()
        {
            if (stack.Count == 0)
            {
                return;
            }
            stack.Pop();
            minStack.Pop();
            if (minStack.Count != 0)
            {
                min = minStack.Peek();
            }
            else
            {
                min = int.MaxValue;
            }
        }

        public int top()
        {
            if (stack.Count == 0)
            {
                return -1;
            }
            return stack.Peek();
        }

        public int getMin()
        {
            if (minStack.Count == 0)
            {
                return -1;
            }
            return minStack.Peek();
        }
    }


}
