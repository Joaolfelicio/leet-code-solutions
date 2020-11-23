/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        ListNode dummyNode = new ListNode();
        ListNode current = dummyNode;
        ListNode currL1 = l1;
        ListNode currL2 = l2;
        int carry = 0;
        
        while(currL1 != null || currL2 != null) {
                  
            int l1Val = (currL1 != null) ? currL1.val : 0;
            int l2Val = (currL2 != null) ? currL2.val : 0;
            if (currL1 != null) currL1 = currL1.next;
            if (currL2 != null) currL2 = currL2.next;

            int sum = l1Val + l2Val + carry;
            carry = sum / 10;
            
            current.next = new ListNode(sum % 10);                     
            current = current.next;
        }
        
        if(carry > 0) {
            current.next = new ListNode(carry--);
        }
        
        return dummyNode.next;
    }
}