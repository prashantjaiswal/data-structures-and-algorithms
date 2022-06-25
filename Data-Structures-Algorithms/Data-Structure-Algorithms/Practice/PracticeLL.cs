using System;
namespace DataStructuresAlgorithms.Practice
{
    public class PracticeLL
    {
        public ListNode ReverseBetween(ListNode A, int B, int C)
        {
            int b1 = B - 1;
            ListNode prev = null;
            ListNode before = null;
            ListNode NN = A;
            B--;
            C = C - B;
            while (B > 0)
            {
                before = NN;
                NN = NN.next;
                B--;
            }

            while (C > 0 && NN != null)
            {
                ListNode temp = NN;
                NN = NN.next;
                temp.next = prev;
                prev = temp;
                C--;
            }
            ListNode newHead;
            if (b1 > 0)
            {
                before.next = prev;
                newHead = A;
            }
            else
                newHead = prev;

            while (prev.next != null)
                prev = prev.next;

            prev.next = NN;
            return newHead;
        }

        public ListNode reverseList(ListNode A)
        {
            ListNode c = A, prev = null;

            while (c != null)
            {
                var temp = c;
                c = c.next;
                temp.next = prev;
                prev = temp;
            }
            return prev;
        }

        static int length = 0;
        static ListNode head = null;
        public static void insert_node(int position, int value)
        {
            // @params position, integer
            // @params value, integer
            if (position > length + 1 || position < 1)
                return;

            ListNode tempNode = new ListNode(value);
            if (head == null || position == 1)
            {
                tempNode.next = head;
                head = tempNode;
            }
            else
            {
                int counter = 1;
                ListNode current = head;
                while (counter < (position - 1))
                {
                    current = current.next;
                    counter += 1;
                }
                tempNode.next = current.next;
                current.next = tempNode;
            }
            length += 1;
        }

        public static void delete_node(int position)
        {
            // @params position, integer
            if (position > length)
                return;
            if (position == 1)
                head = head.next;
            else
            {
                ListNode curr = head;
                int counter = 1;
                while (counter < (position - 1))
                {
                    counter += 1;
                    curr = curr.next;
                }
                curr.next = curr.next.next;
            }
            length -= 1;
        }

        public static void print_ll()
        {
            // Output each element followed by a space
            ListNode tempNode = head;
            while (tempNode != null)
            {
                Console.Write(tempNode.val + " ");
                tempNode = tempNode.next;
            }
        }

        public ListNode detectCycle(ListNode a)
        {
            //flagging each traversed node's next with new node to detect if it was traversed

            if (a == null || a.next == a)
            {
                return a;
            }

            var newNode = new ListNode();
            var curr = a;
            while (curr.next != null && curr.next != newNode)
            {
                var next = curr.next;
                curr.next = newNode;
                curr = next;
            }
            if (curr.next == null)
            {
                return null;
            }
            return curr;
        }

        public ListNode breakCircle(ListNode A)
        {
            if (A == null || A.next == null)
            {
                return null;
            }

            ListNode slow = A;
            ListNode fast = A;

            bool loop = false;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    loop = true;
                    break;
                }
            }

            if (!loop)
            {
                return A;
            }

            slow = A;
            while (slow != fast)
            {
                if (slow.next == fast.next)
                {
                    fast.next = null;
                    break;
                }
                fast = fast.next;
                slow = slow.next;

            }
            return A;
        }

        public ListNode reorderList(ListNode A)
        {
            if (A.next == null || A.next.next == null)
                return A;

            ListNode fast_pointer = A;
            ListNode slow_pointer = A;

            //To find the middle
            while (fast_pointer.next != null && fast_pointer.next.next != null)
            {
                fast_pointer = fast_pointer.next.next;
                slow_pointer = slow_pointer.next;
            }


            //Reverse the second half
            ListNode start = slow_pointer.next;
            slow_pointer.next = null;
            ListNode pre = null;
            ListNode next = null;

            while (start != null)
            {
                next = start.next;
                start.next = pre;
                pre = start;
                start = next;
            }


            //Join two linkedList
            ListNode p1 = A;
            ListNode p1_next = p1.next;
            ListNode p2 = pre;
            ListNode p2_next = p2.next;
            while (p2 != null)
            {
                p1.next = p2;
                p2.next = p1_next;
                p1 = p1_next;
                p2 = p2_next;

                if (p1 == null || p2 == null)
                    break;

                p1_next = p1.next;
                p2_next = p2.next;
            }

            return A;
        }

        public ListNode sortList(ListNode A)
        {
            if (A == null || A.next == null)
            {
                return A;
            }
            ListNode mid = findMid(A);              // find middle to split the list
            ListNode left = sortList(A);            // Sort the left subpart of the list
            ListNode right = sortList(mid);         // Sort the right subpart of the list
            return mergeList(left, right);           // Atlast Merge both the sorted sublists
        }

        public ListNode findMid(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode mid = slow.next;
            slow.next = null;
            return mid;
        }

        public ListNode mergeList(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode(0);
            ListNode tail = head;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                tail = tail.next;
            }
            tail.next = list1 != null ? list1 : list2;
            return head.next;
        }

        public ListNode mergeTwoLists(ListNode A, ListNode B)
        {
            ListNode start = new ListNode(0);
            var s = start;
            while (A != null && B != null)
            {
                //1, 2, 3, 4, 9
                //1, 3, 8, 8, 9
                if (A.val >= B.val)
                {
                    start.next = B;
                    B = B.next;
                }
                else
                {
                    start.next = A;
                    A = A.next;
                }
                start = start.next;
            }
            start.next = (A == null) ? B : A;
            s = s.next;
            return s;
        }

        public int lPalin(ListNode A)
        {
            //1 2 3 4 3 2 1
            var head = A;
            var mid = findMid(head);
            var s1 = mid;
            ListNode prev = null;
            while(s1 != null)
            {
                var temp = s1.next;
                s1.next = prev;
                prev = s1;
                s1 = temp;
            }

            while(prev!= null && head!= null)
            {
                if (prev.val != head.val) return 0;
                prev = prev.next;
                head = head.next;
            }
            return 1;
        }
        
    }

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode() { }
      public ListNode(int x) { this.val = x; this.next = null; }
    }
}

