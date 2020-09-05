using System;
using DataStructuresAlgorithms.BinarySearchTree;
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
            bst.Insert("Papa", 9);
            bst.Insert("Mummy", 4);
            bst.Insert("Didi", 6);
            bst.Insert("Bhaiya", 20);
            bst.Insert("Me", 170);
            bst.Insert("Wife", 15);
            bst.Insert("Kid", 1);

            Assert.True(bst.root.value == "Bhaiya");
        }
    }
}
