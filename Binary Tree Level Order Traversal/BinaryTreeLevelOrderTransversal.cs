using System;

IList<IList<int>> LevelOrder(TreeNode root) 
{
    var result = new List<IList<int>>();
    var queue = new Queue<TreeNode>();
    
    if(root == null) return result;
    
    queue.Enqueue(root);
    
    while(queue.Count > 0)
    {
        var levelResult = new List<int>();
        var levelSize = queue.Count;
        
        for(var i = 0; i < levelSize; i++)
        {
            var curr = queue.Dequeue();
            
            if(curr.left != null)
            {
                queue.Enqueue(curr.left);
            }
            if(curr.right != null)
            {
                queue.Enqueue(curr.right);
            }
            
            levelResult.Add(curr.val);
        }        
        result.Add(levelResult);
    }    
    return result;
}