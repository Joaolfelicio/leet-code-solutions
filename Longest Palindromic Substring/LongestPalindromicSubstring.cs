public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        if(string.IsNullOrWhiteSpace(s)) return string.Empty;
        
        var bestLeft = 0;
        var length = 0;
        
        // Odd length
        for(int mid = 0; mid < s.Length; mid++)
        {           
            for(int i = 0; mid - i >= 0 && mid + i < s.Length; i++)
            {
                var left = mid - i;
                var right = mid + i;
                
                if(s[left] != s[right]) break;
                
                if(right - left >= length)
                {
                    bestLeft = left;
                    length = right - left + 1;
                }
            }
        }
        
        // Even length
        for(int mid = 0; mid < s.Length - 1; mid++)
        {
            for(int i = 0; mid - i + 1 >= 0 && mid + i < s.Length; i++)
            {
                var left = mid - i + 1;
                var right = mid + i;
                
                if(s[left] != s[right]) break;
                
                if(right - left >= length)
                {
                    bestLeft = left;
                    length = right - left + 1;
                }
            }
        }
        
        return s.Substring(bestLeft, length);
    }
}