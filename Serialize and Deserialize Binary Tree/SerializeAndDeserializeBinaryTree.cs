/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    private const string nullVal = "x";
    private const string splitChar = ",";
    
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) 
    {
        var sb = new StringBuilder();
        
        var queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        
        while(queue.Count > 0)
        {
            var current = queue.Dequeue();
            
            if(current != null)
            {
                sb.Append(current.val + splitChar);
                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
            }
            else
            {
                sb.Append(nullVal + splitChar);
            }
        }
        
        // Remove the last separator;
        sb.Length -= splitChar.Length;
        
        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) 
    {
        var dataArr = data.Split(splitChar[0]);
               
        return transverse(dataArr);
    }
    
    private TreeNode transverse(string[] data)
    {
        var queue = new Queue<TreeNode>();
        
        if(data[0] == nullVal) return null;
        
        var index = 0;
        
        var root = new TreeNode(Int32.Parse(data[index++]));
        
        queue.Enqueue(root);
        
        while(queue.Count > 0)
        {
            var curr = queue.Dequeue();
            
            if(data[index] != nullVal)
            {
                var leftNode = new TreeNode(Int32.Parse(data[index]));
                curr.left = leftNode;
                queue.Enqueue(leftNode);
            }
            index++;
            
            if(data[index] != nullVal)
            {
                var rightNode = new TreeNode(Int32.Parse(data[index]));
                curr.right = rightNode;
                queue.Enqueue(rightNode);
            }
            index++;
        }
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));