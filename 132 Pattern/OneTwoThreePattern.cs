public class Solution 
{
    public bool Find132pattern(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return false;
        
        var min = nums[0];
        
        for(int j = 0; j < nums.Length; j++)
        {
            min = Math.Min(min, nums[j]);
            
            if(min == nums[j]) continue;
            
            for(int k = j + 1; k < nums.Length; k++)
            {
                if(nums[k] < nums[j] && min < nums[k]) return true;
            }        
        }
        
        return false;
    }
}