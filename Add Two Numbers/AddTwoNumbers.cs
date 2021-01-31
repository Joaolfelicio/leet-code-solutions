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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        var rest = 0;
        var dummyHead = new ListNode();
        var current = dummyHead;
        
        while(l1 != null || l2 != null)
        {
            var sum = 0;
            
            if(l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            
            if(l2 != null) 
            {
                sum += l2.val;
                l2 = l2.next;
            }
            
            sum += rest;
            
            rest = sum / 10;
            
            current.next = new ListNode(sum % 10);
            
            current = current.next;
        }
        
        if(rest > 0) current.next = new ListNode(1);
        
        return dummyHead.next;
    }
}