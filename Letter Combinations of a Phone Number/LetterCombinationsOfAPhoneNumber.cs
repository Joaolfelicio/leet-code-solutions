public class Solution 
{
    public IList<string> LetterCombinations(string digits) 
    {
        var result = new List<string>();
        
        if(string.IsNullOrWhiteSpace(digits)) return result;
        
        var mapping = GetMapping();
        var sb = new StringBuilder();
        
        Backtrack(digits, 0, mapping, result, sb);
        
        return result;
    }
    
    private void Backtrack(string digits, int index, string[] mappings, List<string> result, StringBuilder current)
    {
        if(index == digits.Length)
        {
            result.Add(current.ToString());
            return;
        }

        var character = digits[index] - '0';
        
        foreach(var letter in mappings[character])
        {
            current.Append(letter);
            Backtrack(digits, index + 1, mappings, result, current);
            current.Length--;
        }
    }
    
    private string[] GetMapping()
    {
        return new string[]
        {
            "",
            "",
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz"
        };
    }
}