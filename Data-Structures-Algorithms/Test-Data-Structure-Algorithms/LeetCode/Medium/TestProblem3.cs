using DataStructuresAlgorithms.Leetcode;
using Xunit;

namespace Test_Data_Structure_Algorithms.LeetCode.Medium
{
    public class TestProblem3
    {
        [Fact]
        public void TestProblem3WithExample1()
        {
            //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            //Output: 7 -> 0 -> 8
            //Explanation: 342 + 465 = 807.
            var problem1 = new Problem1();
            ListNode l1 = new ListNode(6, new ListNode(5, new ListNode(8)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            //856 + 465 = 1321 -> 1231
            var solution = problem1.AddTwoNumbers(l1, l2);
            Assert.True(solution.val == 1);
            Assert.True(solution.next.val == 2);
            Assert.True(solution.next.next.val == 3);
            Assert.True(solution.next.next.next.val == 1);
        }

        [Fact]
        public void TestProblem3WithExample1ZeroInMiddle()
        {
            //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            //Output: 7 -> 0 -> 8
            //Explanation: 342 + 465 = 807.
            var problem1 = new Problem1();
            ListNode l1 = new ListNode(1, new ListNode(0, new ListNode(1)));
            ListNode l2 = new ListNode(2, new ListNode(0, new ListNode(2)));
            //101 + 202 = 303 -> 303
            var solution = problem1.AddTwoNumbers(l1, l2);
            Assert.True(solution.val == 1);
            Assert.True(solution.next.val == 0);
            Assert.True(solution.next.next.val == 3);
        }

        [Fact]
        public void TestProblem3WithExample1WithZero()
        {
            //Input: (0) + (0)
            //Output: 0
            //Explanation: 342 + 465 = 807.
            var problem1 = new Problem1();
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);
            //856 + 465 = 1321 -> 1231
            var solution = problem1.AddTwoNumbers(l1, l2);
            Assert.True(solution.val == 0);
        }

        [Fact]
        public void TestProblem3WithExample1WithSIngleDigits()
        {
            //Input: (0) + (0)
            //Output: 0
            //Explanation: 342 + 465 = 807.
            var problem1 = new Problem1();
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(1);
            //856 + 465 = 1321 -> 1231
            var solution = problem1.AddTwoNumbers(l1, l2);
            Assert.True(solution.val == 1);
        }
    }
}
