public class Solution 
{
    public IList<string> GenerateParenthesis(int n) 
    {
        var result = new List<string>();
        
        if(n == 0) return result;
        
        Backtracking(result, "", 0, 0, n);
        
        return result;
    }
    
    private void Backtracking(List<string> result, string current, int open, int close, int n)
    {
        // If current string has the desired length (n * 2), add and stop
        if(current.Length == n * 2)
        {
            result.Add(current);
            return;
        }
        
        // If there are less opening parentheses than n (where n will be the maximum number of either
        // opening or closing parentheses)
        if(open < n) Backtracking(result, current + "(", open + 1, close, n);
        
        // If there are less closing parentheses than opening parentheses
        if(close < open) Backtracking(result, current + ")", open, close + 1, n);
    }
}