using System;

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
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) 
    {       
        return HasPathSum(root, sum, 0);
    }
    
    public bool HasPathSum(TreeNode root, int target, int currSum)
    {
        if(root == null) return false; 
        
        int currentValue = currSum + root.val;
        
        if(root.left == null && root.right == null) return currentValue == target; 
        
        return HasPathSum(root.left, target, currentValue) || HasPathSum(root.right, target, currentValue);
    }
}