public class Solution 
{
    public IList<string> LetterCombinations(string digits) 
    {
        var result = new List<string>();
        
        if(string.IsNullOrWhiteSpace(digits)) return result;
        
        var mapping = new string[]
        {
            "0",
            "1",
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz"
        };
                
        Backtrack(result, mapping, digits, "", 0);
        return result;
    }
    
    private void Backtrack(List<string> result, string[] mapping, string digits, string current, int index)
    {
        if(index == digits.Length)
        {
            result.Add(current);
            return;
        }
        
        var letters = mapping[digits[index] - '0'];
        for(int i = 0; i < letters.Length; i++)
        {
            Backtrack(result, mapping, digits, $"{current}{letters[i]}", index + 1);
        }
    }
}