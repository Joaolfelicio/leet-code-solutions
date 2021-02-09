public class Solution 
{
    public int PivotIndex(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return -1;
        
        var n = nums.Length;
        var sum = 0;
        var leftSum = 0;
        
        foreach(var num in nums) sum += num;
        
        for(int i = 0; i < n; i++)
        {
            if(leftSum == sum - leftSum - nums[i]) return i;
            leftSum += nums[i];
        }

        return -1;
    }
}