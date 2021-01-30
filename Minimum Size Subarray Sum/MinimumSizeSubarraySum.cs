public class Solution 
{
    public int MinSubArrayLen(int s, int[] nums) 
    {
        if(nums == null || nums.Length == 0) return 0;
        
        var start = 0;
        var end = 0;
        var currentSum = 0;
        var result = Int32.MaxValue;
        
        while(end < nums.Length)
        {
            currentSum += nums[end];
            
            while(currentSum >= s)
            {
                result = Math.Min(result, end - start + 1);
                
                currentSum -= nums[start];
                start++;
            }
            end++;
        }
        
        return result == Int32.MaxValue ? 0 : result;
    }
}