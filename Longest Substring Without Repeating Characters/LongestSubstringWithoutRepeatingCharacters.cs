public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        if(string.IsNullOrEmpty(s)) return 0;
        
        var max = 0;
        var used = new HashSet<char>();
        
        var left = 0;
        var right = 0;
        
        while(right < s.Length)
        {
            if(!used.Contains(s[right]))
            {
                used.Add(s[right]);
                right++;
                max = Math.Max(max, right - left);
            }
            else
            {
                used.Remove(s[left]);
                left++;
            }
        }
        
        return max;
    }
}