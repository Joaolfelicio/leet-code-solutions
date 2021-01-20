public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        var n = nums.Length;
        
        var result = new int[n];
        
        result[0] = 1;
        
        for(int i = 1; i < n; i++)
        {
            result[i] = nums[i - 1] * result[i - 1];  
        }
        
        int rightSide = 1;
        
        for(int i = n - 1; i >= 0; i--)
        {
            result[i] = result[i] * rightSide;
            rightSide *= nums[i];
        }
        
        return result;
    }
}