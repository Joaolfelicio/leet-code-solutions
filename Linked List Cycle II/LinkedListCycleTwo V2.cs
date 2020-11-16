using System;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

public ListNode DetectCycle(ListNode head) 
{
    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        fast = fast.next.next;
        slow = slow.next;

        if (fast == slow)
        {    
            ListNode p1 = head; 
            
            while (p1 != slow)
            {
                slow = slow.next;
                p1 = p1.next;
            }
            return slow;
        }
    }
    return null;
}