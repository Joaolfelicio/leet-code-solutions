public class Solution 
{
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {      
        if(strs == null || strs.Length == 0) return new List<IList<string>>();
        
        var anagrams = new Dictionary<string, List<string>>();
        
        foreach(var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedStr = new String(charArray);
            
            if(!anagrams.ContainsKey(sortedStr))
            {
                anagrams[sortedStr] = new List<string>() {str};
            }
            else
            {
                anagrams[sortedStr].Add(str);
            }
        }
        
        
        return new List<IList<string>>(anagrams.Values);
    }
}