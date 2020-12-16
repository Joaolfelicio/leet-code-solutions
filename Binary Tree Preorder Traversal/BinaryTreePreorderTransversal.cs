using System;

IList<int> PreorderTraversal(TreeNode root) 
{
    return PreOrderTrans(root, new List<int>());
}

IList<int> PreOrderTrans(TreeNode root, IList<int> result) 
{
    if(root == null) return result;
    
    result.Add(root.val);

    PreOrderTrans(root.left, result);
    PreOrderTrans(root.right, result);

    return result;
}