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
    public TreeNode SearchBST(TreeNode root, int val) 
    {
        return SearchTree(root, val);        
    }
    
    public TreeNode SearchTree(TreeNode root, int val)
    {
        if(root == null) return null;
        if(root.val == val) return root;
        
        if(root.val > val) 
        {
            return SearchTree(root.left, val);
        }
        else
        {
            return SearchTree(root.right, val);
        }
    }
}