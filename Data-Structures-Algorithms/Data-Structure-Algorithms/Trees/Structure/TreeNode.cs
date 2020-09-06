using System;
namespace DataStructuresAlgorithms.Trees.Structure
{
    public class TreeNode<T>
    {
        public TreeNode(NodeValue<T> node)
        {
            this.node = node;
            this.left = null;
            this.right = null;
        }

        public NodeValue<T> node { get; private set; }
        public TreeNode<T> left { get; set; }
        public TreeNode<T> right { get; set; }
    }

    public class NodeValue<T>
    {
        public NodeValue(T value, int order)
        {
            this.val = value;
            this.order = order;
        }
        public T val { get; set; }
        public int order { get; set; }
    }
}
