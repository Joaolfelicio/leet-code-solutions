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
    var nodes = new HashSet<ListNode>();
    
    while(head != null && head.next != null)
    {
        nodes.Add(head);                     
        
        if(nodes.TryGetValue(head.next, out var nodesVal))
        {
            return nodesVal;
        }
        
        head = head.next;
    }
    
    return null;
}