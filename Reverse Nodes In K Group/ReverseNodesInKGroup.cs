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
    public ListNode ReverseKGroup(ListNode head, int k) 
    {
        var count = 0;
        var ptr = head;
        
        while(ptr != null && count < k)
        {
            ptr = ptr.next;
            count++;
        }
        
        if(count != k) return head;
        
        var reversedHead = Reverse(head, k);
        
        head.next = ReverseKGroup(ptr, k);
        return reversedHead;
    }
    
    private ListNode Reverse(ListNode head, int k)
    {
        ListNode newHead = null;
        var ptr = head;
        
        while(k > 0)
        {
            var nextNode = ptr.next;
            
            ptr.next = newHead;
            newHead = ptr;
            
            ptr = nextNode;
            
            k--;
        }
        
        return newHead;
    }
}