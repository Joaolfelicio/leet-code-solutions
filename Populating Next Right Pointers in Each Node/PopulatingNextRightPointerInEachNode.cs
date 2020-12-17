using System;

/*
Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution 
{
    public Node Connect(Node root) 
    {
        if(root == null) return null;
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        
        while(queue.Count > 0)
        {
            int depthLength = queue.Count;
                        
            for(int i = 0; i < depthLength; i++)
            {
                Node current = queue.Dequeue();
                
                //If it's not the last node of a level
                if(i != depthLength - 1)
                {
                    current.next = queue.Peek();
                }
                
                if(current.left != null) queue.Enqueue(current.left);
                if(current.right != null) queue.Enqueue(current.right);
            }
        }        
        return root;
    }   
}