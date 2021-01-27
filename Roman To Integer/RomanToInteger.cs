public class Solution {
    public int RomanToInt(string s) {
        if(string.IsNullOrWhiteSpace(s)) return 0;
        
        var values = new Dictionary<char, int>()
        {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
        };
        
        var sum = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            
            // If current char is smaller than next, we need to subtract   
            if(i + 1 < s.Length && values[c] < values[s[i + 1]]) sum -= values[c];
            else sum += values[c];
            
        }
        return sum;
    }
}