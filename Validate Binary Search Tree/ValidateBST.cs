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
    public bool IsValidBST(TreeNode root) 
    {
        return IsValidBST(root, Int64.MinValue, Int64.MaxValue);
    }
    
    private bool IsValidBST(TreeNode node, double min, double max)
    {
        if(node == null) return true;
        
        var isValid = node.val > min && node.val < max;
        
        return isValid && IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
    }
}