public class Solution 
{
    public string MinWindow(string s, string t) 
    {
        
        if(s == null || t == null || s.Length == 0 || t.Length == 0 || t.Length > s.Length) return string.Empty;
        
        var target = GetTarget(t);
        var stringSearch = new Dictionary<char, int>();
        
        // Position 0, the result length. Position 1, the starting index
        var result = new int[] {Int32.MaxValue, 0};
        
        var start = 0;
        var end = 0;
        var charsEqual = 0;
        
        while(end < s.Length)
        {
            var c = s[end];
            
            // If it's not the target chars, we can continue
            if(!target.ContainsKey(c)) 
            {
                end++;
                continue;
            }
            
            // Incrase the s dictionary with the count for that char
            stringSearch.TryGetValue(c, out var quantity);
            stringSearch[c] = quantity + 1;
            
            // If the target dictionary for this char is bigger or equal, we increment the equal chars
            if(stringSearch[c] <= target[c]) charsEqual++;
            
            // If the equals chars is equal to the t length, it's a valid substring, so we can assign result
            // and try to reduce the window by increasing the start pointer
            if(charsEqual == t.Length)
            {                
                while(start <= end && charsEqual == t.Length)
                {
                    var current = s[start];
                    
                    // If the current substring length is smaller than the previous result
                    if(result[0] > end - start + 1)
                    {
                        result[0] = end - start + 1;
                        result[1] = start;
                    }
                    
                    // If the char we are removing from the window is not the target char, we can ignore and continue
                    if(!stringSearch.ContainsKey(current))
                    {
                        start++;
                        continue;
                    }
                    
                    // Since we are removing it from the window, decrease this char quantity
                    stringSearch[current] = stringSearch[current] - 1;
                    
                    // If the char in the target dictionary is bigger than in the string dictionary
                    // it means the string doesn't have the target chars, so decrease charEquals
                    if(stringSearch[current] < target[current]) charsEqual--;
                    
                    start++;
                }
            }
            end++;
        }
        // If the result[0] is equal to maxValue, we didn't find any valid combination, else return substring
        return result[0] == Int32.MaxValue ? string.Empty : s.Substring(result[1], result[0]);
    }
    
    private Dictionary<char, int> GetTarget(string t)
    {
        var result = new Dictionary<char, int>();
        
        foreach(var c in t)
        {
            result.TryGetValue(c, out var quantity);
            result[c] = quantity + 1;
        }
        
        return result;
    }

}