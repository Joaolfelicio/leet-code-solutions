using System;

int MaxDepth(TreeNode root) 
{
    if(node == null) 
    {
        return 0;
    }        
    
    return Math.Max(MaxDepth(node.left), MaxDepth(node.right)) + 1;
}

