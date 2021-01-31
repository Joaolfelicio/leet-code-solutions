public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return -1;
        
        // Gauss' Formula (factorial but for sum)
        var expectedSum = nums.Length * (nums.Length + 1) / 2;
        
        for(int i = 0; i < nums.Length; i++) expectedSum -= nums[i];
        
        return expectedSum;
    }
}