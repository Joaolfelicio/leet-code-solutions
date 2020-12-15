using System;

public int DeepestLeavesSum(TreeNode root) 
{
    var queue = new Queue<TreeNode>();
    
    queue.Enqueue(root);
    
    int sum = 0;
    
    while(queue.Count > 0) 
    {
        sum = 0;
        
        int depthSize = queue.Count;
        
        for(int i = 0; i < depthSize; i++) 
        {
            var current = queue.Dequeue();
            
            if(current.left != null) 
            {
                queue.Enqueue(current.left);
            }
            if(current.right != null) 
            {
                queue.Enqueue(current.right);
            }
            
            sum += current.val;
        }
    }
    return sum;
}