class Solution {
    public int maxDepth(TreeNode root) {
        return maxDepth(root, 0);
    }
    
    public int maxDepth(TreeNode root, int depth) {
        if(root == null) return 0;
        
        return Math.max(maxDepth(root.left, depth), maxDepth(root.right, depth)) + 1;
    }
}