public class Solution {
    public bool IsValid(string s) 
    {
        if(string.IsNullOrWhiteSpace(s)) return true;
        if(s.Length % 2 != 0) return false;
        
        var parentheses = GetParenthesesDict();
        var stack = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            
            if(parentheses.ContainsKey(c)) 
            {
                stack.Push(parentheses[c]);
                continue;
            }
            
            if(stack.Count == 0 || stack.Pop() != c) return false;
        }
        
        return stack.Count == 0;
    }
    
    private Dictionary<char, char> GetParenthesesDict()
    {
        return new Dictionary<char, char>()
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };
    }
        
}