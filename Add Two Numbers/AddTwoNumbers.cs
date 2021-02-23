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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        if(l1 == null && l2 == null) return null;
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        var currL1 = l1;
        var currL2 = l2;
        var dummyHead = new ListNode();
        var curr = dummyHead;
        var rest = 0;
        
        while(currL1 != null || currL2 != null)
        {
            var l1val = currL1 != null ? currL1.val : 0;
            var l2val = currL2 != null ? currL2.val : 0;
            
            var sum = l1val + l2val + rest;
            
            curr.next = new ListNode(sum % 10);
            
            rest = sum / 10;
            
            curr = curr.next;
            if(currL1 != null) currL1 = currL1.next;
            if(currL2 != null) currL2 = currL2.next;
        }
        
        if(rest == 1) curr.next = new ListNode(rest);
        
        return dummyHead.next;
    }
}