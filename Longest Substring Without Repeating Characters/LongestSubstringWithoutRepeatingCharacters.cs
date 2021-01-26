public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        if(string.IsNullOrEmpty(s)) return 0;
        
        var seen = new HashSet<char>();
        
        var maxSum = 0;
        var start = 0;
        var end = 0;
        
        while(start < s.Length && end < s.Length)
        {
            if(!seen.Contains(s[end]))
            {
                seen.Add(s[end++]);
                maxSum = Math.Max(maxSum, end - start);
            }
            else
            {
                seen.Remove(s[start++]);
            }
        }
        return maxSum;
    }
}