public class Solution 
{
    public int FindKthLargest(int[] nums, int k) 
    {
        if(nums == null || nums.Length == 0 || k <= 0) return -1;
        
        var sortedDict = FillHeap(nums);
        
        foreach(var num in sortedDict.Keys)
        {
            k -= sortedDict[num];
            if(k <= 0) return num;
        }
        return -1;
    }
    
    private SortedDictionary<int, int> FillHeap(int[] nums)
    {
        var result = new SortedDictionary<int, int>(Comparer<int>.Create((a, b) => b - a));

        foreach(var num in nums)
        {
            result.TryGetValue(num, out var quantity);
            result[num] = quantity + 1;
        }
        
        return result;
    }
}