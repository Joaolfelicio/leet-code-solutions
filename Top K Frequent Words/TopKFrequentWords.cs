public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var result = new int[k];
        
        if(nums == null || nums.Length == 0 || k == 0) return result;  
        
        var numsQuantity = GetNumsQuantity(nums)
                            .OrderByDescending(x => x.Value)
                            .Take(k)
                            .ToDictionary(x => x.Key);
                            
        
        int index = 0;
        foreach(var key in numsQuantity.Keys)
        {
            result[index] = key;
            index++;
        }
        
        return result;
    }
    
    private Dictionary<int, int> GetNumsQuantity(int[] nums)
    {
        var result = new Dictionary<int, int>();
        
        foreach(var num in nums)
        {
            result.TryGetValue(num, out var quantity);
            result[num] = quantity + 1;
        }
        
        return result;
    }
}