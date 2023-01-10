using System.Collections.Generic;
using System.Linq;

namespace Problems._100._Same_Tree
{
    public class Problem100
    {
        private List<int> _queue1;
        private List<int> _queue2;
        
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            _queue1 = new List<int>();
            _queue2 = new List<int>();
            GetTreeData(p, _queue1);
            GetTreeData(q, _queue2);

            return _queue1.SequenceEqual(_queue2);
        }

        private void GetTreeData(TreeNode treeNode, List<int> queue)
        {
            if (treeNode == null)
            {
                queue.Add(int.MinValue);
                return;
            }
            queue.Add(treeNode.val);

            GetTreeData(treeNode.left, queue);
            GetTreeData(treeNode.right, queue);
        }
    }
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    } 
}