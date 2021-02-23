public class Solution 
{
    public bool IsAlienSorted(string[] words, string order) 
    {
        var indexes = new int[26];
        
        for(int i = 0; i < order.Length; i++)
        {
            indexes[order[i] - 'a'] = i; 
        }
        
        for(int i = 0; i < words.Length - 1; i++)
        {
            var word1 = words[i];
            var word2 = words[i + 1];
            
            if(!CompareWords(word1, word2, indexes)) return false;
        }
        
        return true;
    }
    
    private bool CompareWords(string word1, string word2, int[] indexes) 
    {
        var n = word1.Length;
        var m = word2.Length;
        
        for(int i = 0; i < n && i < m; i++)
        {
            if(word1[i] == word2[i]) continue;
            
            return indexes[word1[i] - 'a'] < indexes[word2[i] - 'a'];
        }
        
        return n <= m;
    }
}