public class Solution 
{
    public int FirstMissingPositive(int[] nums) 
    {
        var n = nums.Length;
        
        for(int i = 0; i < n; i++)
        {
            if(nums[i] <= 0 || nums[i] > n) nums[i] = n + 1;
        }
        
        for(int i = 0; i < n; i++)
        {
            var num = Math.Abs(nums[i]);
            
            if(num > n) continue;
            
            // Set the number negative
            if(nums[num - 1] > 0) nums[num - 1] *= -1;
        }
        
        for(int i = 0; i < n; i++) if(nums[i] > 0) return i + 1;
        
        return n + 1;
    }
}