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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {       
        return FindAncestor(root, q, p);
    }
    
    private TreeNode FindAncestor(TreeNode current, TreeNode q, TreeNode p)
    {
        if(current == null) return null;

        if(current == q || current == p) return current;

        var nodeLeft = FindAncestor(current.left, q, p);

        var nodeRight = FindAncestor(current.right, q, p);

        //If both are not null, we found the ancestor
        if(nodeLeft != null && nodeRight != null) 
        {
            return current;
        } 
        else if(nodeLeft != null) 
        {
            return nodeLeft;
        } 
        else if(nodeRight != null) 
        {
            return nodeRight;
        }
        return null;
    }
}