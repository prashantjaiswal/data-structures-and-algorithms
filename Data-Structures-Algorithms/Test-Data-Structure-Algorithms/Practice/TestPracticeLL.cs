using System;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
	public class TestPracticeLL
	{
        [Fact]
        public void TestReverseBetween()
        {
            //1 -> 2 -> 3 -> 4 -> 5
            //2, 4

            var list = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            

            PracticeLL practice = new PracticeLL();
            var result = practice.ReverseBetween(list, 2, 4);
        }

        [Fact]
        public void TestSumOfTwoIndices()
        {
            var fourth = new ListNode(4);
            var third = new ListNode(3){next = fourth};
            fourth.next = third;
            var list = new ListNode(1){ next = new ListNode(2) { next = fourth } };

            PracticeLL practice = new PracticeLL();
            var result = practice.detectCycle(list);
        }

        [Fact]
        public void TestmergeTwoLists()
        {
            //1 -> 2 -> 3 -> 4 -> 5
            //2, 4

            var list1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(9)
                        }
                    }
                }
            };
            var list2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(8)
                    {
                        next = new ListNode(8)
                        {
                            next = new ListNode(9)
                        }
                    }
                }
            };

            PracticeLL practice = new PracticeLL();
            var result = practice.mergeTwoLists(list1, list2);
        }

        [Fact]
        public void TestSort()
        {
            //1 -> 2 -> 3 -> 4 -> 5
            //2, 4

            var list = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(3)
                            {
                                next = new ListNode(2)
                                {
                                    next = new ListNode(1)
                                }
                            }
                        }
                    }
                }
            };

            var list2 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(1)
                    }
                }
            };


            PracticeLL practice = new PracticeLL();
            var result = practice.lPalin(list);
            practice.lPalin(list2);
        }
    }

}

