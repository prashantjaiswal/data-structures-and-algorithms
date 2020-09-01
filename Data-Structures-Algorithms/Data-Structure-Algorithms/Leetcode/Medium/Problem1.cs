using System;
namespace DataStructuresAlgorithms.Leetcode
{
    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers.
    /// The digits are stored in reverse order and each of their nodes contain a single digit.
    /// Add the two numbers and return it as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// </summary>
    public class Problem1
    {
        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode listNode = null;
            ListNode currentNode = null;
            while(l1 != null || l2 != null)
            {
                int sum = 0;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                if(listNode == null)
                {
                    listNode = new ListNode(sum % 10);
                    if (!(l1 == null && l2 == null && (sum / 10 == 0 || sum == 0)))
                        listNode.next = new ListNode(sum / 10);
                    currentNode = listNode.next;
                }
                else
                {
                    currentNode.val += (sum % 10);
                    if (!(l1 == null && l2 == null && (sum / 10 == 0 || sum == 0)))
                        currentNode.next = new ListNode(sum / 10);
                    currentNode = currentNode.next;
                }
            }

            return listNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
