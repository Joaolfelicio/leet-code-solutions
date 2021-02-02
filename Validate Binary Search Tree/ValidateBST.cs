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
    
    public bool IsValidBST(TreeNode root, long left, long right)
    {
        if(root == null) return true;
        
        var rootVal = (long) root.val;
        
        var isNodeValid = left < rootVal && rootVal < right;
        
        return isNodeValid && IsValidBST(root.left, left, rootVal) && IsValidBST(root.right, rootVal, right);
    }
}