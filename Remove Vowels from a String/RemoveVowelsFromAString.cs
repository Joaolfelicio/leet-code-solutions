public class Solution 
{
    public string RemoveVowels(string s) 
    {
        var sb = new StringBuilder();
        
        foreach(var c in s)
        {
            if(c == 'a' || c == 'e' || c == 'i' || c == 'o'|| c == 'u')
                continue;
            
            sb.Append(c);
        }
        
        return sb.ToString();
    }

}