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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
    {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
  
        var dummyHead = new ListNode();
        var current = dummyHead;
        
        while(l1 != null && l2 != null)
        {
            if(l1.val < l2.val)
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
        
        if(l1 == null) current.next = l2;
        else if(l2 == null) current.next = l1;
        
        return dummyHead.next;
    }
}