public class FreqStack 
{
    private Dictionary<int, int> Frequency {get;}
    private Dictionary<int, Stack<int>> FreqNums {get;}
    private int HighestFreq {get; set;}
    
    public FreqStack() 
    {
        Frequency = new Dictionary<int, int>();
        FreqNums = new Dictionary<int, Stack<int>>();
        HighestFreq = 0;
    }
    
    public void Push(int x) 
    {
        Frequency.TryGetValue(x, out var quantity);
        
        quantity++;
        
        Frequency[x] = quantity;
        
        // Keep record for the highest frequency
        HighestFreq = Math.Max(HighestFreq, quantity);
        
        // Keep a dictionary<int, stack> with frequency -> elements
        if(!FreqNums.ContainsKey(quantity)) FreqNums[quantity] = new Stack<int>();
        
        FreqNums[quantity].Push(x);
    }
    
    public int Pop() 
    {
        var popped = FreqNums[HighestFreq].Pop();
        
        // If the stack is empty, there are no more elems for that freq, so reduce 
        // the highest frequency
        if(FreqNums[HighestFreq].Count == 0) HighestFreq--;
        
        // Reduce the frequency for that elem by one, since we popped it
        Frequency[popped] = Frequency[popped] - 1;
        
        return popped;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 */