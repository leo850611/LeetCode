using System.Collections.Generic;
using Problems.Models;

namespace Problems._226._Invert_Binary_Tree
{
    // https://leetcode.com/problems/invert-binary-tree/
    public class Problem226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            
            var rootLeft = root.left;
            root.left = root.right;
            root.right = rootLeft;

            InvertTree(root.right);
            InvertTree(root.left);

            return root;
        }
        
        public TreeNode InvertTree_while(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            if (root != null)
            {
                queue.Enqueue(root);
            }

            while (queue.Count != 0)
            {
                var treeNode = queue.Dequeue();
                
                var rootLeft = treeNode.left;
                treeNode.left = treeNode.right;
                treeNode.right = rootLeft;

                if (treeNode.left != null)
                {
                    queue.Enqueue(treeNode.left);
                }

                if (treeNode.right != null)
                {
                    queue.Enqueue(treeNode.right);
                }
            }

            return root;
        }
    }
}