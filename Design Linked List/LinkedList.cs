using System;

public class LinkedList 
{
    int length;
    Node head;
    Node tail;
   
    /** Initialize your data structure here. */
    public LinkedList() 
    {
        length = 0;
        head = null;
        tail = null;
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) 
    {      
        var node = GetNode(index);
        
        if(node == null)
        {
            return -1;
        }
        return node.val;
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val) 
    {
        head = new Node(val, head);
        
        if(tail == null)
        {
            tail = head;
        }
        
        length++;
    }
    
    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val) 
    {
        var newNode = new Node(val, null);
        
        if(tail != null)
        {
           tail.next = newNode;
        }
        
        if(head == null)
        {
            head = newNode;
        }
               
        tail = newNode;
        
        length++;
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) 
    {
        if(index > length || index < 0)
        {
            return;
        }
        else if(index == 0)
        {
            AddAtHead(val);
        }
        else if(index == length)
        {
            AddAtTail(val);
        }
        else
        {
            var prevNode = GetNode(index - 1);
            
            var temp = prevNode.next;
            
            prevNode.next = new Node(val, temp);
            
            length++;
        }
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) 
    {
        if(length == 0 || index >= length || index < 0)
        {
            return;
        }
        else if(index == 0)
        {           
            head = head.next;
        }
        else if(index == length - 1)
        {
            var prevTail = GetNode(length - 2);
            
            prevTail.next = null;
            
            tail = prevTail;
        }
        else
        {
            var prevNode = GetNode(index - 1);
                        
            prevNode.next = prevNode.next.next;
        }
        
        length--;
    }
    
    private Node GetNode(int index)
    {
        if(length == 0 || index >= length || index < 0)
        {   
            return null;
        }
        else if(index == 0)
        {
            return head;
        }
        else if(index == length - 1)
        {
            return tail;
        }
        
        var currNode = head;
        
        while(index > 0)
        {   
            currNode = currNode.next;
            
            index--;
        }
        
        return currNode;
    }
}

public class Node
{
    public int val;
    public Node next;
    
    public Node(int val, Node next)
    {
        this.val = val;
        this.next = next;
    }
}

/**
 * Your LinkedList object will be instantiated and called as such:
 * LinkedList obj = new LinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */