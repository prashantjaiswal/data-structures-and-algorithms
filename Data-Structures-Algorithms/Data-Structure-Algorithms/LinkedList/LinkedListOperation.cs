using System;
using System.Collections.Generic;
using System.Text;
using DataStructuresAlgorithms.LinkedList.Structure;

namespace DataStructuresAlgorithms.LinkedList
{
    public class LinkedListOperation
    {
        public void Reverse(LinkedList<int> list)
        {
            Node<int> previous = new Node<int>(0);
            Node<int> next = list.head;
            Node<int> current = new Node<int>(0);
            //list.tail = next;
            while (next.next != null)
            {
                previous = current;
                current = next;
                next = next.next;

            }
        }
    }
}
