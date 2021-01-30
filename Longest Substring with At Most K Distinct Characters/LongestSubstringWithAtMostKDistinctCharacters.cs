public class Solution 
{
    public int LengthOfLongestSubstringKDistinct(string s, int k) 
    {
        if(k == 0 || string.IsNullOrEmpty(s)) return 0;
        
        var uniques = new Dictionary<char, int>();
        var maxLength = 0;
        
        var start = 0;
        var end = 0;
        
        while(end < s.Length)
        {
            var c = s[end];
            
            if(!uniques.ContainsKey(c) && uniques.Count == k)
            {              
                if(uniques[s[start]] == start) uniques.Remove(s[start]);
                
                start++;
            }
            else
            {
                if(!uniques.ContainsKey(c)) uniques.Add(c, end);
                else uniques[c] = end;
                
                end++;
            }
            maxLength = Math.Max(maxLength, end - start);
        }
        
        return maxLength;
    }
}