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
    public int SumEvenGrandparent(TreeNode root) 
    {
        if(root == null) return 0;
        
        return SumEvenGrandparent(root, null, null, 0);
    }
    
    public int SumEvenGrandparent(TreeNode root, TreeNode parent, TreeNode grandparent, int sum) 
    {
        if(root == null) return 0;
        
        var currSum = grandparent != null && grandparent.val % 2 == 0 ? root.val : 0;
        
        var childSum = SumEvenGrandparent(root.left, root, parent, sum) + SumEvenGrandparent(root.right, root, parent, sum);
        
        return childSum + currSum + sum;
    }
}
