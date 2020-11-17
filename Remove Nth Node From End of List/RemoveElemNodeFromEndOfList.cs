using System;

public ListNode RemoveNthFromEnd(ListNode head, int n) 
{
    int length = 0;
    
    var current = head;
    
    while(current != null)
    {
        length++;  
        current = current.next;
    }
    
    if(length < n)
    {
        return null;
    }
    else if(length == n)
    {
        return head.next;
    }
    
    current = head;
    
    for(int p1 = 0; p1 < length - n - 1; p1++)
    {
        current = current.next;            
    }
    
    if(current.next.next == null)
    {
        current.next = null;
    } 
    else
    {
        current.next = current.next.next;
    }
    
    return head;
}
