using System;

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
    public ListNode RemoveElements(ListNode head, int val) 
    {
        if(head == null)
        {
            return null;
        }
        
        ListNode prev = null;
        ListNode current = head;
        
        while(current != null)
        {
            if(current.val == val)
            {
                if(prev == null)
                {
                    head = current.next;
                }
                else
                {
                    prev.next = current.next;
                }
            }
            else
            {
                prev = current;
            }
            
            current = current.next;
        }
        
        return head;
    }
}