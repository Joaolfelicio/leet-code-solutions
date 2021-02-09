public class Solution 
{
    public int MinStartValue(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return Int32.MinValue;
        
        var minVal = Int32.MaxValue;
        var sum = 0;
        
        foreach(var num in nums) 
        {
            sum += num;
            minVal = Math.Min(minVal, sum);
        }
        
        return minVal <= 0 ? Math.Abs(minVal) + 1 : 1;
    }
}