using System;
using DataStructuresAlgorithms.BinarySearchTree;
using DataStructuresAlgorithms.Trees.Structure;
using Xunit;

namespace Test_Data_Structure_Algorithms
{
    public class TestBinarySearchTree
    {
        [Fact]
        public void TestBSTInsert()
        {
            BinarySearchTree<string> bst = new BinarySearchTree<string>();

            //Family Tree
            bst.Insert(new NodeValue<string> ("Papa", 9));
            bst.Insert(new NodeValue<string>("Mummy", 4));
            bst.Insert(new NodeValue<string>("Didi", 6));
            bst.Insert(new NodeValue<string>("Bhaiya", 20));
            bst.Insert(new NodeValue<string>("Me", 170));
            bst.Insert(new NodeValue<string>("Wife", 15));
            bst.Insert(new NodeValue<string>("Kid", 1));

            Assert.False(bst.root.node.val == "Bhaiya");
            Assert.True(bst.root.node.val == "Papa");
        }

        [Fact]
        public void TestBSTLookup()
        {
            BinarySearchTree<string> bst = new BinarySearchTree<string>();

            //Family Tree
            bst.Insert(new NodeValue<string>("Papa", 9));
            bst.Insert(new NodeValue<string>("Mummy", 4));
            bst.Insert(new NodeValue<string>("Didi", 6));
            bst.Insert(new NodeValue<string>("Bhaiya", 20));
            bst.Insert(new NodeValue<string>("Me", 170));
            bst.Insert(new NodeValue<string>("Wife", 15));
            bst.Insert(new NodeValue<string>("Kid", 1));
            var lookedUp = bst.LookUp(new NodeValue<string> ("Dummy", 9));

            Assert.True(lookedUp.node.val == "Papa");
        }
    }
}
