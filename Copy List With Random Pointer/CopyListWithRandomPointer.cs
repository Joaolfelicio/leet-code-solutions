/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        
        if(head == null) return null;
        
        // Key: "real" node, Value: copy node
        var copies = new Dictionary<Node, Node>();
       
        var dummyHead = new Node(-1);
        var currHead = dummyHead;
        
        while(head != null)
        {
            Node newNode;
            
            if(copies.ContainsKey(head))
            {
                newNode = copies[head];
            }
            else
            {
                newNode = new Node(head.val);
                copies.Add(head, newNode);
            }          
            
            currHead.next = newNode;
            
            if(head.random != null && !copies.ContainsKey(head.random))
            {
                copies.Add(head.random, new Node(head.random.val));
            }
            
            newNode.random = head.random != null ? copies[head.random] : null;
            
            head = head.next;
            currHead = currHead.next;
        }
        
        return dummyHead.next;
    }
}