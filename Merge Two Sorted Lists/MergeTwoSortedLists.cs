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

ListNode MergeTwoLists(ListNode l1, ListNode l2) 
{
    ListNode head = new ListNode();
    
    ListNode current = head;
    
    while(l1 != null || l2 != null) 
    {         
        if(l1 != null && (l2 == null || l1.val <= l2.val)) 
        {
            current.next = l1;
            l1 = l1.next;
        }
        else
        {
            current.next = l2;
            l2 = l2.next;
        }
        current = current.next;
    }
    return head.next;
}
