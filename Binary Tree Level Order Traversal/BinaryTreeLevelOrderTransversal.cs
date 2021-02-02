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
    public IList<IList<int>> LevelOrder(TreeNode root) 
    {
        var result = new List<IList<int>>();
        
        if(root == null) return result;
        
        var nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);
        
        while(nodes.Count > 0)
        {
            var size = nodes.Count;
            var subList = new List<int>();
            
            for(int i = 0; i < size; i++)
            {
                var current = nodes.Dequeue();
                
                subList.Add(current.val);
                
                if(current.left != null) nodes.Enqueue(current.left);
                if(current.right != null) nodes.Enqueue(current.right);
            }
            result.Add(subList);
        }
        return result;
    }
}