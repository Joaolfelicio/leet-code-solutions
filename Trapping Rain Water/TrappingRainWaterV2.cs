public class Solution 
{ 
    // O(n) Time
    // O(1) Space  
    public int Trap(int[] height) 
    {
        if(height == null || height.Length == 0) return 0;

        var left = 0;
        var right = height.Length - 1;

        var trapped = 0;

        var leftMax = 0;
        var rightMax = 0;

        while(left <= right)
        {
            rightMax = Math.Max(rightMax, height[right]);
            leftMax = Math.Max(leftMax, height[left]);
            
            if(leftMax > rightMax)
            {
                trapped += Math.Min(rightMax, leftMax) - height[right];
                right--;
            }
            else
            {
                trapped += Math.Min(rightMax, leftMax) - height[left];
                left++;
            }
        }
        return trapped;
    }
}