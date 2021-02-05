public class Solution 
{
    public IList<string> GenerateParenthesis(int n) 
    {
        var result = new List<string>();
        var sb = new StringBuilder();
        
        Backtrack(result, sb, n, n);
        
        return result;
    }
    
    private void Backtrack(List<string> result, StringBuilder current, int left, int right)
    {
        if(left == 0 && right == 0)
        {
            result.Add(current.ToString());
            return;
        }
        
        if(left > 0)
        {
            current.Append("(");
            Backtrack(result, current, left - 1, right);
            current.Length--;
        }
        
        if(left < right)
        {
            current.Append(")");
            Backtrack(result, current, left, right - 1);
            current.Length--;
        }
    }
}