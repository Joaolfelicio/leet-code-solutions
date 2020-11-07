using System;

void DeleteNode(ListNode node) 
{
    ExchangeNode(node);
}

void ExchangeNode(ListNode node)
{       
    node.val = node.next.val;

    if(node.next.next != null)
    {
        ExchangeNode(node.next);  
    }
    else
    {
        node.next = null;    
    }
}