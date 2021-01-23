public class Solution 
{
    public IList<string> LetterCombinations(string digits) 
    {
        var result = new List<string>();
        
        if(string.IsNullOrWhiteSpace(digits)) return result;
        
        var mapping = new Dictionary<char, string>()
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };
                
        Backtrack(result, mapping, digits, "", 0);
        return result;
    }
    
    private void Backtrack(List<string> result, Dictionary<char, string> mapping, string digits, string current, int index)
    {
        if(index == digits.Length)
        {
            result.Add(current);
            return;
        }
        
        var letters = mapping[digits[index]];
        for(int i = 0; i < letters.Length; i++)
        {
            Backtrack(result, mapping, digits, $"{current}{letters[i]}", index + 1);
        }
    }
}