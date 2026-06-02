/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> ans = new List<IList<int>>();

        if (root == null) return ans;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int sz = q.Count;
            List<int> temp = new List<int>();

            for (int i = 0; i < sz; i++)
            {
                TreeNode node = q.Dequeue();

                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);

                temp.Add(node.val);
            }

            ans.Add(temp);
        }

        return ans;
    }
}