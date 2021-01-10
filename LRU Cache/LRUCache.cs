public class LRUCache 
{
    private Dictionary<int, int> Dict {get; set; }
    private List<int> KeysUsedOrder {get; set; }
    private int Capacity {get; set;}

    public LRUCache(int capacity) 
    {
        Dict = new Dictionary<int, int>(capacity);
        KeysUsedOrder = new List<int>(capacity);
        Capacity = capacity;
    }
    
    public int Get(int key) 
    {
        if(!ContainsKey(key)) return -1;
        
        UpdateLastUsed(key);
        
        return Dict[key];
    }
    
    public int Put(int key, int value) 
    {
        if(ContainsKey(key)) 
        {          
            Dict[key] = value;
            
            UpdateLastUsed(key);
            
            return value; 
        }
        
        if(IsFull()) RemoveLeastUsed();
        
        Dict[key] = value;
        
        UpdateLastUsed(key);

        return value;
    }
    
    private void RemoveLeastUsed()
    {
        if(!HasAny()) return;
        
        var leastUsed = KeysUsedOrder[0];
        
        KeysUsedOrder.RemoveAt(0);
        Dict.Remove(leastUsed);
    }
    
    private void UpdateLastUsed(int key)
    {
        KeysUsedOrder.Remove(key);
        
        var index = HasAny() ? KeysUsedOrder.Count : 0;
        
        KeysUsedOrder.Insert(index, key);
    }
    
    public bool ContainsKey(int key) => Dict.ContainsKey(key);
    public bool IsFull() => KeysUsedOrder.Count == Capacity; 
    public bool HasAny() => KeysUsedOrder.Count > 0;
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */