public class Solution 
{   
    public int Trap(int[] height) 
    {
        if(height == null || height.Length == 0) return 0;
        
        var leftMax = new int[height.Length];
        leftMax[0] = height[0];
        
        var rightMax = new int[height.Length];
        rightMax[height.Length - 1] = height[height.Length - 1];
        
        for(int i = 1; i < leftMax.Length; i++)
            leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
        
        for(int i = rightMax.Length - 2; i >= 0; i--)
            rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
        
        var trapped = 0;
        
        for(int i = 0; i < height.Length; i++)
        {
            var left = leftMax[i];
            var right = rightMax[i];
            
            trapped += Math.Min(left, right) - height[i];
        }
        return trapped;
    }
}