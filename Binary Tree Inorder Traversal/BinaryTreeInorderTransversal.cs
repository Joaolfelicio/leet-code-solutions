using System;

IList<int> InorderTraversal(TreeNode root) 
{
    var result = new List<int>();
    Transverse(root, result);
    return result;
}

void Transverse(TreeNode root, IList<int> result) 
{
    if(root == null) return;
    
    Transverse(root.left, result);
    result.Add(root.val);
    Transverse(root.right, result);
}