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
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        return Reverse(head, null);
    }
    
    public ListNode Reverse(ListNode head, ListNode prev)
    {
        if(head == null) return prev;
        
        var nextNode = head.next;
        
        head.next = prev;
        
        return Reverse(nextNode, head);
    }
}