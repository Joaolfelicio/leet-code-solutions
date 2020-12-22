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
    private int BalancedDifference = 1;
    
    public bool IsBalanced(TreeNode root) 
    {
        return TreeDifference(root) >= 0;
    }
    
    public int TreeDifference(TreeNode root)
    {
        if(root == null) return 0;
                
        var leftTree = TreeDifference(root.left);
        var rightTree = TreeDifference(root.right);
        
        if(leftTree == -BalancedDifference || rightTree == -BalancedDifference) return -BalancedDifference;
        
        if(Math.Abs(leftTree - rightTree) > BalancedDifference) return -BalancedDifference;
        
        return Math.Max(leftTree, rightTree) + 1;
    }
}