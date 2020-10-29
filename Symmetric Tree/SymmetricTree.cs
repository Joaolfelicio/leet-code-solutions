using System;

bool IsSymmetric(TreeNode root) 
{
    return IsMirror(root.left, root.right);
}

bool IsMirror(TreeNode leftNode, TreeNode rightNode)
{
    if(leftNode == null && rightNode == null)
    {
        return true;
    }
    
    if(leftNode == null || rightNode == null)
    {
        return false;
    }
    
    return (leftNode.val == rightNode.val) 
        && IsMirror(leftNode.right, rightNode.left)
        && IsMirror(leftNode.left, rightNode.right);
}
