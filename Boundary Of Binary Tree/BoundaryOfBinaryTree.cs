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
    private bool IsLeaf(TreeNode node) => node.left == null && node.right == null;
    
    private void AddLeaves(TreeNode root, List<int> result)
    {
        if(IsLeaf(root)) result.Add(root.val);
        else
        {
            if(root.left != null) AddLeaves(root.left, result);
            if(root.right != null) AddLeaves(root.right, result);
        }
    }
    
    private void AddLeft(TreeNode root, List<int> result)
    {
        while (root != null) 
        {
            if (!IsLeaf(root)) result.Add(root.val);
            
            if (root.left != null) root = root.left;
            else root = root.right;
        }
    }
    
    private void AddRight(TreeNode root, List<int> result)
    {
        var s = new Stack<int>();
        
        while (root != null) 
        {
            if (!IsLeaf(root)) s.Push(root.val);
            
            if (root.right != null) root = root.right;
            else root = root.left;
        }
        
        while (s.Count > 0) result.Add(s.Pop());
    }
    
    public IList<int> BoundaryOfBinaryTree(TreeNode root) 
    {
        var res = new List<int>();
        if (root == null) return res;
        
        // Add Root
        if (!IsLeaf(root)) res.Add(root.val);

        AddLeft(root.left, res);
        AddLeaves(root, res);
        AddRight(root.right, res);
        
        return res;
    }
}