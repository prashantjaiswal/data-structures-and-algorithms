using System;
using Xunit;
using DataStructuresAlgorithms.LinkedList;

namespace Test_Data_Structure_Algorithms
{
    public class TestLinkedList
    {
        [Fact]
        public void TestLinkedListWhereHeadIsInitialised()
        {
            var list = new LinkedList<int>(31);
            Assert.True(list.head.value == 31);
        }

        [Fact]
        public void TestLinkedListWhereGivenNodeIsAppended()
        {
            var list = new LinkedList<int>(31); //head
            var appendedNode = list.Append(22);
            Assert.Same(appendedNode,list.head.next);
        }

        [Fact]
        public void TestLinkedListWhereGivenNodeIsPrepended()
        {
            var list = new LinkedList<int>(31); //head
            var prependedNode = list.Prepend(22);
            Assert.Same(prependedNode, list.head);
        }
    }
}
