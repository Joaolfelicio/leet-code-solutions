public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return -1;
        
        int sum = 0;
        int maxSum = nums[0];

        for (int i = 0; i < nums.Length; i++) 
        {
            sum += nums[i];

            // If the current num is bigger than the prev sum, we can overwrite
            if (nums[i] > sum) sum = nums[i];
            maxSum = Math.Max(maxSum, sum);
        }
    
        return maxSum;
    }
}