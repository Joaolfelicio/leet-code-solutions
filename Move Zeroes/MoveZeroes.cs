public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return;
        
        var numZeroes = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0) 
            {
                numZeroes++;
                continue;
            }
            
            nums[i - numZeroes] = nums[i];
        }
        
        for(int i = nums.Length - numZeroes; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}