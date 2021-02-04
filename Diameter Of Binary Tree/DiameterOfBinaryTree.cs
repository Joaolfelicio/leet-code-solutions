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
    private int MaxValue {get; set;} = 1;
    
    public int DiameterOfBinaryTree(TreeNode root) 
    {       
        MaxPath(root);
        return MaxValue - 1;
    }
    
    private int MaxPath(TreeNode root) 
    {
        if(root == null) return 0;
        
        var left = MaxPath(root.left);
        var right = MaxPath(root.right);
        
        MaxValue = Math.Max(MaxValue, left + right + 1);
        
        return Math.Max(left, right) + 1;
    }
}