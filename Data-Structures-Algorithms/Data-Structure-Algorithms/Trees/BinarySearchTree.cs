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

        public TreeNode<T> Insert(T value, int order)
        {
            var newNode = new TreeNode<T>(value, order);

            if (this.root == null)
            {
                this.root = newNode;
                return this.root;
            }
            TreeNode<T> currentNode = this.root;

            while (true)
            {
                if (currentNode.order > order)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        return newNode;
                    }
                    currentNode = currentNode.left;
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        return newNode;
                    }
                    currentNode = currentNode.right;
                }
            }
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
