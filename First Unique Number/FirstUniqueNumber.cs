public class FirstUnique 
{
    public Dictionary<int, LinkedListNode<int>> Dict {get; }
    public LinkedList<int> Uniques {get; }

    public FirstUnique(int[] nums) 
    {
        Dict = new Dictionary<int, LinkedListNode<int>>();
        Uniques = new LinkedList<int>();
        
        foreach(var num in nums)
        {
            Add(num);
        }
    }
    
    public int ShowFirstUnique() 
    {
        if(Uniques.Count > 0) return Uniques.First.Value;
        
        return -1;
    }
    
    public void Add(int value) 
    {       
        if(Dict.ContainsKey(value))
        {
            RemoveNonUnique(value);
            return;
        }
        
        Uniques.AddLast(value);        
        Dict.Add(value, Uniques.Last);
    }

    
    private void RemoveNonUnique(int num) 
    {
        var node = Dict[num];
        
        if(node == null) return;
        
        Uniques.Remove(node);
        
        Dict[num] = null;
    }
}

/**
 * Your FirstUnique object will be instantiated and called as such:
 * FirstUnique obj = new FirstUnique(nums);
 * int param_1 = obj.ShowFirstUnique();
 * obj.Add(value);
 */