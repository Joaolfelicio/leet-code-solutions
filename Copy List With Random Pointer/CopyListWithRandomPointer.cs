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

public class Solution 
{
    public Node CopyRandomList(Node head) 
    {
        var dummyHead = new Node(0);
        var current = dummyHead;
        
        var clones = new Dictionary<Node, Node>();
        
        while(head != null)
        {
            Node node;
            
            if(!clones.ContainsKey(head)) 
            {            
                var newNode = new Node(head.val);
                node = newNode;
                clones.Add(head, newNode);
            }
            else
            {
                node = clones[head];
            }
            
            current.next = node;
             
            Node randomNode = null;
            if(head.random != null)
            {
                if(!clones.ContainsKey(head.random)) 
                    clones.Add(head.random, new Node(head.random.val));
                randomNode = clones[head.random];
            }
            
            node.random = randomNode;
            
            current = current.next;
            head = head.next;
        }
        return dummyHead.next;
    }
}