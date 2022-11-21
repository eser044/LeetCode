using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Answers
{
    public class HasPathSum
    {
        public static void Run()
        {
            TreeNode root = new TreeNode { val = 5, left = new TreeNode { val = 4, left = new TreeNode { val = 11, left = new TreeNode { val = 7 }, right = new TreeNode { val = 2 } } }, right = new TreeNode { val = 8, left = new TreeNode { val = 13 }, right = new TreeNode { val = 4, right = new TreeNode { val = 1 } } } };
            var input = 22;
            Solution(root, input);
        }

        public static bool Solution(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            if (root.left == null && root.right == null && targetSum - root.val == 0)
                return true;

            return Solution(root.left, targetSum - root.val) || Solution(root.right, targetSum - root.val);
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
