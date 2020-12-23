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
    private void Helper(TreeNode node, int currSum, int allSum, ref int res, ISet<TreeNode> roots)
    {
        if (node == null) return;

        if (node.val == currSum) res++;

        Helper(node.left, currSum - node.val, allSum, ref res, roots);
        
        if (node.left != null && roots.Add(node.left))
        {
            Helper(node.left, allSum, allSum, ref res, roots);
        }

        Helper(node.right, currSum - node.val, allSum, ref res, roots);

        if (node.right != null && roots.Add(node.right))
        {
            Helper(node.right, allSum, allSum, ref res, roots);
        }
    }

    public int PathSum(TreeNode root, int sum)
    {
        if (root == null)
        {
            return 0;
        }

        int res = 0;
        Helper(root, sum, sum, ref res, new HashSet<TreeNode>());
        return res;
    }

}