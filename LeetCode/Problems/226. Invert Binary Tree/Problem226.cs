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
    }
}