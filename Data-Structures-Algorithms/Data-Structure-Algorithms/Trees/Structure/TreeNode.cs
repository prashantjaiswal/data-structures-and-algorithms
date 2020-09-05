using System;
namespace DataStructuresAlgorithms.Trees.Structure
{
    public class TreeNode<T>
    {
        public TreeNode(T value, int order)
        {
            this.value = value;
            this.left = null;
            this.right = null;
            this.order = order;
        }

        public T value { get; set; }
        public TreeNode<T> left { get; set; }
        public TreeNode<T> right { get; set; }
        public int order { get; set; }
    }
}
