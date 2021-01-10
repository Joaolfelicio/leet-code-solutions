public class LRUCache 
{
    class DLinkedNode 
    {
        public int Key;
        public int Value;
        public DLinkedNode Prev;
        public DLinkedNode Next;
        
        public DLinkedNode() {}
        
        public DLinkedNode(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
    
    private void AddNode(DLinkedNode node) 
    {
        // Add new node after head
        node.Prev = Head;
        node.Next = Head.Next;
        
        Head.Next.Prev = node;
        Head.Next = node;
    }
    
    private void RemoveNode(DLinkedNode node)
    {
        // Remove existing node
        var prev = node.Prev;
        var next = node.Next;
        
        prev.Next = next;
        next.Prev = prev;
    }
    
    private void MoveToHead(DLinkedNode node)
    {
        // Move node in between to the head;
        RemoveNode(node);
        AddNode(node);
    }
    
    private DLinkedNode PopTail()
    {
        var result = Tail.Prev;
        RemoveNode(result);
        return result;
    }
    
    private Dictionary<int, DLinkedNode> Cache = new Dictionary<int, DLinkedNode>();
    private int Size;
    private int Capacity;
    private DLinkedNode Head;
    private DLinkedNode Tail;
    
    public LRUCache(int capacity)
    {
        Size = 0;
        Capacity = capacity;
        
        Head = new DLinkedNode();
        Tail = new DLinkedNode();
        
        Head.Next = Tail;
        Tail.Prev = Head;
    }
    
    public int Get(int key)
    {
        if(!ContainsKey(key)) return -1;
        
        var node = Cache[key];
        
        MoveToHead(node);
        
        return node.Value;
    }
    
    public void Put(int key, int value)
    {
        if(ContainsKey(key))
        {
            var node = Cache[key];
            node.Value = value;
            
            MoveToHead(node);
        }
        else
        {
            if(IsFull()) RemoveLeastUsed();
            
            var node = new DLinkedNode(key, value);
            
            Cache.Add(key, node);
            Size++;           
            
            AddNode(node);
        }
    }
    
    private void RemoveLeastUsed()
    {
        var tail = PopTail();
        Cache.Remove(tail.Key);
        Size--;
    }
    
    
    
    public bool ContainsKey(int key) => Cache.ContainsKey(key);
    public bool IsFull() => Size == Capacity; 
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */