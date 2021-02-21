public class Solution 
{
    public int TwoSumLessThanK(int[] nums, int k) 
    {
        var result = -1;
        
        if(nums == null || nums.Length == 0) return result;
        
        Array.Sort(nums);
        
        var left = 0;
        var right = nums.Length - 1;
        
        while(left < right)
        {
            var sum = nums[left] + nums[right];
            
            if(sum >= k)
            {
                right--;
            }
            else if(sum < k)
            {
                left++;
                result = Math.Max(sum, result);
            }
        }
        
        return result;
    }

}