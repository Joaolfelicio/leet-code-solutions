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
        int rest = 0;
        
        while(l1 != null || l2 != null || rest > 0) {
             
            if(l1 == null && l2 == null) {
                current.next = new ListNode(rest);
                rest--;   
                
            }
            else if(l1 == null) {
                int newVal = l2.val;
                
                if(rest > 0) {
                    newVal += rest;
                    rest--;
                }
                
                if(newVal > 9) {
                    current.next = new ListNode(newVal % 10);
                    rest++;
                }
                else {
                    current.next = new ListNode(newVal);
                }
                
                l2 = l2.next;
                
            }
            else if(l2 == null) {
                int newVal = l1.val;
                                
                if(rest > 0) {
                    newVal += rest;
                    rest--;
                }
                
                if(newVal > 9) {
                    current.next = new ListNode(newVal % 10);
                    rest++;
                }
                else {
                    current.next = new ListNode(newVal);
                }
                
                l1 = l1.next;
                
            }
            else {
                int newVal = l1.val + l2.val;
                
                if(rest > 0) {
                    newVal += rest;
                    rest--;
                }
                
                if(newVal > 9) {
                    current.next = new ListNode(newVal % 10);
                    rest++;
                }
                else {
                    current.next = new ListNode(newVal);
                }
                
                l2 = l2.next;
                l1 = l1.next;
                
            }
            
            current = current.next;
        }
        
        return dummyNode.next;
    }
}