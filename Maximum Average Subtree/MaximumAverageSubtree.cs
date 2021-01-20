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
    public double MaximumAverageSubtree(TreeNode root) 
    {
        if(root == null) return 0;
        
        return GetAverageSubtree(root).MaxAverage;
    }
    
    private AverageSubtree GetAverageSubtree(TreeNode root)
    {
        if(root == null) return null;
        
        var leftNode = GetAverageSubtree(root.left);
        var rightNode = GetAverageSubtree(root.right);
        
        double sum = 0;
        var nodesCount = 1;
        double maxAverage = 0;
        
        if(leftNode != null) 
        {
            nodesCount += leftNode.NodesCount;
            sum += leftNode.Sum;
            maxAverage = Math.Max(maxAverage, leftNode.MaxAverage);
        }
        
        if(rightNode != null)
        {
            nodesCount += rightNode.NodesCount;
            sum += rightNode.Sum;
            maxAverage = Math.Max(maxAverage, rightNode.MaxAverage);
        }
        
        sum += root.val;
       
        return new AverageSubtree(nodesCount, sum, Math.Max(maxAverage, sum / nodesCount));
    }
}

public class AverageSubtree
{
    public double Sum {get; }
    public double MaxAverage {get; }
    public int NodesCount {get;}
       
    public AverageSubtree(int nodesCount, double sum, double maxAverage)
    {
        NodesCount = nodesCount;
        Sum = sum;
        MaxAverage = maxAverage;
    }
}