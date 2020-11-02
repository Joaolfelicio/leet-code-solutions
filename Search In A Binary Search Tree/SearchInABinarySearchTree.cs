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

TreeNode SearchBST(TreeNode root, int val) {
    return SearchTree(root, val);        
}
    
TreeNode SearchTree(TreeNode root, int val)
{
    if(root.val == val)
    {
        return root;
    }
    
    if(root.val > val && root.left != null)
    {
        return SearchTree(root.left, val);
    } 
    else if(root.val < val && root.right != null)
    {
        return SearchTree(root.right, val);
    }
    
    return null;
}
