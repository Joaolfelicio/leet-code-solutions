public class Solution 
{
    public bool WordBreak(string s, IList<string> wordDict) 
    {
        if(string.IsNullOrWhiteSpace(s) || wordDict == null || wordDict.Count == 0) return false;
        
        var table = new bool[s.Length + 1];
        table[0] = true;
        
        for(int i = 0; i < table.Length; i++)
        {
            if(!table[i]) continue;
            
            foreach(var word in wordDict)
            {
                if(i + word.Length >= table.Length) continue;
                
                var sSubstring = s.Substring(i, word.Length);
                
                if(word.Equals(sSubstring)) table[i + word.Length] = true;
            }
        }
        
        
        return table[table.Length - 1];
    }
}