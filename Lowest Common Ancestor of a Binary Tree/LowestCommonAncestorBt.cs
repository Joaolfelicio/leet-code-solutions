/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

 // Brute force
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {       
        var ancestorTable = new Dictionary<TreeNode, TreeNode>();
        
        populateHashAncestor(root, ancestorTable);
        
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
    
    private void populateHashAncestor(TreeNode root, Dictionary<TreeNode, TreeNode> ancestorTable)
    {
        if(root == null) return;
        
        if(root.left != null)
        {
            ancestorTable.TryAdd(root.left, root);
        }
        if(root.right != null)
        {
            ancestorTable.TryAdd(root.right, root);
        }
        
        populateHashAncestor(root.left, ancestorTable);
        populateHashAncestor(root.right, ancestorTable);
    }
}

// Recursive BFS
public class Solution2 {
    
    private TreeNode Ancestor = null;
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {       
        LowestCommonAncestorHelper(root, q, p);
        return Ancestor;
    }
    
    private bool LowestCommonAncestorHelper(TreeNode currNode, TreeNode p, TreeNode q)
    {
        if(currNode == null) return false;
        
        int leftSide = LowestCommonAncestorHelper(currNode.left, q, p) ? 1 : 0;
        
        int rightSide = LowestCommonAncestorHelper(currNode.right, q, p) ? 1 : 0;
        
        int mid = (currNode == p || currNode == q) ? 1 : 0;
        
        if(mid + leftSide + rightSide >= 2)
        {
            Ancestor = currNode;
        }
        
        return (mid + leftSide + rightSide > 0);
    }
}