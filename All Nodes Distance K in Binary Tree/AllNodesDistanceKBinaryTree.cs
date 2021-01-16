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
    public IList<int> DistanceK(TreeNode root, TreeNode target, int K) 
    {
        var ancestors = GetAncestors(root, new Dictionary<TreeNode, TreeNode>());
        
        var queue = new Queue<TreeNode>();
        var visited = new HashSet<TreeNode>();
        
        var result = new List<int>();
        
        queue.Enqueue(target);
        
        while(queue.Count > 0)
        {
            var size = queue.Count;
            
            for(int i = 0; i < size; i++)
            {               
                var current = queue.Dequeue();
                visited.Add(current);
                
                if(K == 0) result.Add(current.val);
                
                if(current.left != null && !visited.Contains(current.left)) 
                    queue.Enqueue(current.left);
                
                if(current.right != null && !visited.Contains(current.right)) 
                    queue.Enqueue(current.right);
                
                if(ancestors.ContainsKey(current) && !visited.Contains(ancestors[current]))
                    queue.Enqueue(ancestors[current]);
            }
            
            if(K == 0) return result;
            
            K--;
        }
        
        return result;
    }
    
    public Dictionary<TreeNode, TreeNode> GetAncestors(TreeNode root, Dictionary<TreeNode, TreeNode> dict)
    {
        if(root == null) return dict;
        
        if(root.left != null) dict.Add(root.left, root);
        if(root.right != null) dict.Add(root.right, root);
        
        GetAncestors(root.left, dict);
        GetAncestors(root.right, dict);
        
        return dict;
    }
}