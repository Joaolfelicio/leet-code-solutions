using System;

IList<int> PostorderTraversal(TreeNode root) 
{
    var result = new List<int>();
    Transverse(root, result);
    return result;
}

void Transverse(TreeNode root, IList<int> result)
{
    if(root == null) return;
    
    Transverse(root.left, result);
    Transverse(root.right, result);
    
    result.Add(root.val);
}