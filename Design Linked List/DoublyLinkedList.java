class DoublyLinkedList {
    int length;
    Node head;
    Node tail;
   
    /** Initialize your data structure here. */
    public DoublyLinkedList() {
        length = 0;
        head = null;
        tail = null;
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    
    public int get(int index) {      
        Node node = getNode(index);
        
        if(node == null) {
            return -1;
        }
        
        return node.val;
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    
    public void addAtHead(int val) {       
        Node newHead = new Node(val, null, head);
        
        if(head != null) {
            head.prev = newHead;
        }
        
        head = newHead;
        
        if(tail == null) {
            tail = head;
        }
        
        length++;
    }
    
    /** Append a node of value val to the last element of the linked list. */
    
    public void addAtTail(int val) {
        Node newNode = new Node(val, tail, null);
        
        if(tail != null) {
           tail.next = newNode;
        }
        
        if(head == null) {
            head = newNode;
        }
               
        tail = newNode;
        
        length++;
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    
    public void addAtIndex(int index, int val) {
        if(index > length || index < 0) {
            return;
            
        } else if(index == 0) {
            addAtHead(val);
            
        } else if(index == length) {
            addAtTail(val);
            
        } else {
            Node prevNode = getNode(index - 1);
            
            Node nextNode = prevNode.next;
            
            Node newNode = new Node(val, prevNode, nextNode);
            
            nextNode.prev = newNode;
            
            prevNode.next = newNode;
            
            length++;
        }
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void deleteAtIndex(int index) {
        
        if(length == 0 || index >= length || index < 0) {
            return;
            
        } else if(index == 0) {   
            head = head.next;
            
            if(head != null) {
               head.prev = null; 
            }
            
        } else if(index == length - 1) {
            
            var prevTail = getNode(length - 2);
            
            prevTail.next = null;
            
            tail = prevTail;
            
        } else {
            
            var prevNode = getNode(index - 1);
            var nextNode = prevNode.next.next;
                        
            prevNode.next = nextNode;
            nextNode.prev = prevNode;
        }
        
        length--;
    }
    
    private Node getNode(int index) {
        
        if(length == 0 || index >= length || index < 0) {   
            return null;
            
        } else if(index == 0) {
            return head;
            
        } else if(index == length - 1) {
            return tail;
        }
        
        Node currNode = head;
        
        while(index > 0) {   
            currNode = currNode.next;
            
            index--;
        }
        
        return currNode;
    }
}

class Node {
    public int val;
    public Node next;
    public Node prev;
    
    public Node(int val, Node prev, Node next) {
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */