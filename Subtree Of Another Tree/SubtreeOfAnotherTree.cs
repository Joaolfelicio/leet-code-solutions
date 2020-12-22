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
    public bool IsSubtree(TreeNode s, TreeNode t) 
    {
        return s != null && (Equals(s, t) || IsSubtree(s.left, t) || IsSubtree(s.right, t));    
    }
    
    private bool Equals(TreeNode s, TreeNode t)
    {
        if(s == null && t == null) return true;
        if(s == null || t == null) return false;
        
        // If the nodes values are the same and all the children nodes are equal
        return s.val == t.val && Equals(s.left, t.left) && Equals(s.right, t.right);
    }
}