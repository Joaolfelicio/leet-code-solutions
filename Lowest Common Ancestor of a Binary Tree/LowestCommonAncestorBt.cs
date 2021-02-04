/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        var ancestorTable = new Dictionary<TreeNode, TreeNode>();
        
        PopulateHashAncestor(root, ancestorTable);
        
        var visitedSet = new HashSet<TreeNode>();
        
        while(p != null || q != null)
        {
            if(p != null)
            {
               if(!visitedSet.Add(p)) return p;
               ancestorTable.TryGetValue(p, out p);
            }
            
            if(q != null)
            {
                if(!visitedSet.Add(q)) return q;
                ancestorTable.TryGetValue(q, out q);
            }            
        }
        return null;
    }
    
    private void PopulateHashAncestor(TreeNode node, Dictionary<TreeNode, TreeNode> ancestors)
    {
        if(node == null) return;
        
        if(node.left != null) ancestors.Add(node.left, node);
        if(node.right != null) ancestors.Add(node.right, node);
        
        PopulateHashAncestor(node.left, ancestors);
        PopulateHashAncestor(node.right, ancestors);
    }
}