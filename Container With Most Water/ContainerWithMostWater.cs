public class Solution 
{
    public int MaxArea(int[] height) 
    {
        if(height == null || height.Length == 0) return 0;
        
        int maxArea = 0;
        int start = 0;
        int end = height.Length - 1;
        
        while(end > start)
        {
            var heightArea = Math.Min(height[start], height[end]);
            var widthArea = end - start;
            
            maxArea = Math.Max(maxArea, heightArea * widthArea);
            
            if(height[start] > height[end])
            {
                end--;
            }
            else
            {
                start++;
            }
        }
        
        return maxArea;
    }
}