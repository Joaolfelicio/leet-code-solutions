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
    if(l1 == null && l2 == null) return null;
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        var dummyHead = new ListNode();
        var currentDummyHead = dummyHead;
        
        var currentl1 = l1;
        var currentl2 = l2;
        
        while(currentl1 != null && currentl2 != null)
        {
            if(currentl1.val <= currentl2.val)
            {
                currentDummyHead.next = currentl1;
                currentl1 = currentl1.next;
            }
            else
            {
                currentDummyHead.next = currentl2;
                currentl2 = currentl2.next;  
            }
            
            currentDummyHead = currentDummyHead.next;
        }
        
        if(currentl2 != null) currentDummyHead.next = currentl2;
        else if(currentl1 != null) currentDummyHead.next = currentl1;
        
        return dummyHead.next;
}
