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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) 
    {
        var result = new List<IList<int>>();
        
        if(root == null) return result;
        
        var depth = 1;
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count > 0)
        {
            int size = queue.Count;    
            
            var level = new LinkedList<int>();
            
            for(int i = 0; i < size; i++)
            {
                TreeNode elem  = queue.Dequeue();
                                
                if(elem.left != null) queue.Enqueue(elem.left);
                if(elem.right != null) queue.Enqueue(elem.right);
                
                if(depth % 2 == 0) level.AddFirst(elem.val);
                else level.AddLast(elem.val);
            }
            
            result.Add(new List<int>(level));
            depth++;
        }
        
        return result;
    }
}