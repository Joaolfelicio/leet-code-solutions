public class Solution 
{
    public int ConnectSticks(int[] sticks) 
    {
        if(sticks == null || sticks.Length <= 1) return 0;
        
        var sticksDict = GetSticksDict(sticks);
        var sum = 0;
        
        while(sticksDict.Count > 1 || sticksDict[sticksDict.Keys.First()] > 2)
        {
            var currentSum = 0;
            
            var smallest = sticksDict.Keys.First();
            currentSum += smallest;
            RemoveEntry(smallest, sticksDict);
            
            var secondSmallest = sticksDict.Keys.First();
            currentSum += secondSmallest;
            RemoveEntry(secondSmallest, sticksDict);
            
            sum += currentSum;
            AddEntry(currentSum, sticksDict);
        }
        
        return sum;
        
    }
    
    private void RemoveEntry(int key, SortedDictionary<int, int> dict)
    {
        if(dict[key] > 1)
        {
            dict[key] = dict[key] - 1;
        }
        else
        {
            dict.Remove(key);
        }
    }
    
    private void AddEntry(int key, SortedDictionary<int, int> dict)
    {
        dict.TryGetValue(key, out var quantity);
        dict[key] = quantity + 1;
    }
    
    private SortedDictionary<int, int> GetSticksDict(int[] sticks)
    {
        var sticksDict = new SortedDictionary<int, int>();
        
        foreach(var stick in sticks)
        {
            AddEntry(stick, sticksDict);
        }
        
        return sticksDict;
    }
}