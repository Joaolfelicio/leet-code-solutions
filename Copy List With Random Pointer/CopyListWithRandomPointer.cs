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
        
        var tempHead = head;
        // Key: "real" node, Value: copy node
        var copies = PopulateDict(tempHead);
       
        var dummyHead = new Node(-1);
        var currHead = dummyHead;
        
        while(head != null)
        {
            var newNode = copies[head];
            currHead.next = newNode;

            // If the random pointer is not null, get the copy reference from the dictionary
            newNode.random = head.random != null ? copies[head.random] : null;
                   
            head = head.next;
            currHead = currHead.next;
        }
        
        return dummyHead.next;
    }
    
    private Dictionary<Node, Node> PopulateDict(Node head)
    {
        var copies = new Dictionary<Node, Node>();
        
        while(head != null)
        {
            var newNode = new Node(head.val);
            
            copies.Add(head, newNode);
                        
            head = head.next;
        }
        
        return copies;
    }
}