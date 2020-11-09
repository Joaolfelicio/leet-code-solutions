using System;

int MaxDepth(TreeNode root) 
{
    return MaxDepth(root, 0);
}

int MaxDepth(TreeNode node, int level)
{
    if(node == null) 
    {
        return 0;
    }        
    
    level++;
    
    int max = level;        
    
    if(node.left != null)
    { 
        var temp = MaxDepth(node.left, level);
        max = Math.Max(temp, max);
    }
    
    if(node.right != null)
    {
        var temp = MaxDepth(node.right, level);
        max = Math.Max(temp, max);
    }
    
    return max;
}
