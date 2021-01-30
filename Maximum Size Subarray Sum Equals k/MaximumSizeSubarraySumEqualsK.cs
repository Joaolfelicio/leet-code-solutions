public class Solution 
{
    public int MaxSubArrayLen(int[] nums, int k) 
    {
        if(nums == null || nums.Length == 0) return 0;
        
        var result = Int32.MinValue;
        var start = 0;
        var end = 0;
        var sum = 0;
        
        while(end < nums.Length)
        {
            sum += nums[end];
            
            if(sum == k) result = Math.Max(result, end - start + 1);

            if(end == nums.Length - 1)
            {
                start++;
                end = start;
                sum = 0;
            }
            else
            {
                end++;
            }
        }
        
        return result == Int32.MinValue ? 0 : result;
    }
}