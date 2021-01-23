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
    public TreeNode BuildTree(int[] preorder, int[] inorder) 
    {
        if(preorder == null || inorder == null || preorder.Length == 0 || inorder.Length == 0) return null;
        
        return Helper(0, 0, inorder.Length - 1, preorder, inorder);
    }

    private TreeNode Helper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder) {
        if (preStart > preorder.Length - 1 || inStart > inEnd) 
        {
            return null;
        }
        
        var root = new TreeNode(preorder[preStart]);
        
        int inIndex = 0; // Index of current root in inorder
        for (int i = inStart; i <= inEnd; i++) 
        {
            if (inorder[i] == root.val) 
            {
                inIndex = i;
                break;
            }
        }
        
        root.left = Helper(preStart + 1, inStart, inIndex - 1, preorder, inorder);
        root.right = Helper(preStart + inIndex - inStart + 1, inIndex + 1, inEnd, preorder, inorder);
        return root;
    }
}