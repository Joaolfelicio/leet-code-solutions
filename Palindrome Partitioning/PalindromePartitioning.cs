public class Solution 
{
    public IList<IList<string>> Partition(string s) 
    {
        var result = new List<IList<string>>();
        var current = new List<string>();
        
        if(string.IsNullOrWhiteSpace(s)) return result;
        
        Backtrack(result, s, 0, current);
        
        return result;
    }
    
    private void Backtrack(List<IList<string>> result, string s, int start, List<string> current)
    {
        if(start == s.Length)
        {
            result.Add(new List<string>(current));
            return;
        }
        
        for(int end = start; end < s.Length; end++)
        {   
            if(!IsPalindrome(s, start, end)) continue;

            current.Add(s.Substring(start, end - start + 1 ));
            Backtrack(result, s, end + 1, current);
            current.RemoveAt(current.Count - 1);
        }
    }
    
    private bool IsPalindrome(string s, int low, int high)
    {
        while (low < high) 
        {
            if (s[low++] != s[high--]) return false;
        }
        return true;
    }   
}
        
        
        