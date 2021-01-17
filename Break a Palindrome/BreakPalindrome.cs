public class Solution 
{
    public string BreakPalindrome(string palindrome) 
    {   
        if(palindrome == null || palindrome.Length < 2) return "";
        
        var result = palindrome.ToCharArray();

        for(int i = 0; i < result.Length / 2; i++)
        {
            if(result[i] != 'a')
            {
                result[i] = 'a';

                return new string(result);
            }
        }
        
        result[result.Length - 1] = 'b';
                
        return new string(result);
    }
}