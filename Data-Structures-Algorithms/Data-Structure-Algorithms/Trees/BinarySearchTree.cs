using System;
using DataStructuresAlgorithms.Trees.Structure;

namespace DataStructuresAlgorithms.BinarySearchTree
{
    public class BinarySearchTree<T>
    {
        public TreeNode<T> root { get; set; }

        public BinarySearchTree()
        {
            this.root = null;
        }

        public TreeNode<T> Insert(NodeValue<T> node)
        {
            var newNode = new TreeNode<T>(node);

            if (this.root == null)
            {
                this.root = newNode;
                return this.root;
            }
            TreeNode<T> current = this.root;

            while (true)
            {
                if (current.node.order > node.order)
                {
                    if (current.left == null)
                    {
                        current.left = newNode;
                        return newNode;
                    }
                    current = current.left;
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = newNode;
                        return newNode;
                    }
                    current = current.right;
                }
            }
        }

        public TreeNode<T> LookUp(NodeValue<T> node)
        {
            var current = this.root;
            while (true && current != null)
            {
                if (current.node.order == node.order)
                {
                    return current;
                }
                else if (current.node.order > node.order)
                {
                    current = current?.left;
                }
                else
                {
                    current = current?.right;
                }
            }
            return default;
        }

        public TreeNode<T> Traverse(TreeNode<T> node)
        {
            TreeNode<T> tree = node;
            tree.left = node.left == null ? null : Traverse(node.left);
            tree.right = node.right == null ? null : Traverse(node.right);
            return tree;
        }
    }
}
