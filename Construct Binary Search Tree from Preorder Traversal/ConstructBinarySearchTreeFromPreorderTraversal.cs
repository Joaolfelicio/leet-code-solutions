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
    public int Index {get; set;} = 0;
    
    public TreeNode BstFromPreorder(int[] preorder) 
    {
        return BstFromPreorder(preorder, Int32.MinValue, Int32.MaxValue);
    }
    

    public TreeNode BstFromPreorder(int[] preorder, int leftMin, int rightMax)
    {
        if(preorder.Length <= Index || preorder[Index] < leftMin || preorder[Index] > rightMax) return null;
        
        var newNode = new TreeNode(preorder[Index++]);
        
        newNode.left = BstFromPreorder(preorder, leftMin, newNode.val);
        newNode.right = BstFromPreorder(preorder, newNode.val, rightMax);
        
        return newNode;
    }
}