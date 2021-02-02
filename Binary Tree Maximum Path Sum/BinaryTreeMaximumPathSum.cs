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
    private int MaxValue = Int32.MinValue;
    
    public int MaxPathSum(TreeNode root)
    {
        MaxGain(root);
        return MaxValue;
    }
    
    private int MaxGain(TreeNode node)
    {
        if(node == null) return 0;
        
        var left = Math.Max(MaxGain(node.left), 0);
        var right = Math.Max(MaxGain(node.right), 0);
        
        int combinedGain = node.val + left + right;
        
        MaxValue = Math.Max(MaxValue, combinedGain);
        
        return node.val + Math.Max(left, right);
    }
}