public class Solution 
{
    public int MaxSubArrayLen(int[] nums, int k) 
    {
        if(nums == null || nums.Length == 0) return 0;
        
        var result = 0;
        var sum = 0;
        
        var sumDict = new Dictionary<int, int>();
        sumDict.Add(0, -1);
        
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            
            if(sumDict.ContainsKey(sum - k)) result = Math.Max(result, i - sumDict[sum - k]);
            if(!sumDict.ContainsKey(sum)) sumDict.Add(sum, i);
        }
        return result;
    }
}