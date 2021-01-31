public class Solution 
{
    public int FirstUniqChar(string s) 
    {
        if(string.IsNullOrWhiteSpace(s)) return -1;
        
        var chars = new int[26];
        for(int i = 0; i < s.Length; i++) 
        {
            var charIndex = s[i] - 'a';
            chars[charIndex] = i;
        }
        
        for(int i = 0; i < s.Length; i++)
        {
            var charIndex = s[i] - 'a';
            if(chars[charIndex] == i) 
                return i;
            else
                chars[charIndex] = -1;
        }
        return -1;
    }
}