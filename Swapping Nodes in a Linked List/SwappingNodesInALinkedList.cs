/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode SwapNodes(ListNode head, int k) 
    {
        if(head == null || head.next == null || k == 0) return head;
        
        var firstIndex = k;
        var nodesCount = 0;
        var curr = head;
        ListNode firstNode = null;
        ListNode lastNode = null;
        
        while(curr != null)
        {
            nodesCount++;
            if(nodesCount == k) firstNode = curr;
            curr = curr.next;
        }
        
        var lastIndex = nodesCount - k + 1;
        
        curr = head;
        var counter = 1;
        
        for(int i = 0; i < lastIndex; i++)
        {
            lastNode = curr;
            curr = curr.next;
        }
        
        var temp = firstNode.val;
        
        firstNode.val = lastNode.val;
        lastNode.val = temp;
        
        return head;
    }
}