public class RandomizedSet 
{  
    private Dictionary<int, int> Set { get; }
    private List<int> List {get; }
    
    /** Initialize your data structure here. */
    public RandomizedSet() 
    {
        Set = new Dictionary<int, int>();
        List = new List<int>();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) 
    {
        if(Set.ContainsKey(val)) return false;
        
        Set.Add(val, List.Count);
        List.Add(val);
        
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) 
    {
        if(!Set.ContainsKey(val)) return false;
        
        // Get the last elem and the index of the elem to remove
        var lastElem = List[List.Count - 1];
        var index = Set[val];
               
        // Swap elem to delete with the last one
        List[List.Count - 1] = val;
        List[index] = lastElem;
        
        // Update set with index for the prev last elem
        Set[lastElem] = index;
        
        // Remove from the set and from the list
        Set.Remove(val);
        List.RemoveAt(List.Count - 1);
            
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() 
    {       
        var randomNum = new Random().Next(List.Count);
               
        return List[randomNum];
    }
}


/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */