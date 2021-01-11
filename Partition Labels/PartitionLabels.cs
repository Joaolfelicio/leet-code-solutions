public class Solution 
{
    public IList<int> PartitionLabels(string S) 
    {
        var result = new List<int>();
        
        if(S == null || S.Length == 0) return result;
        
        var lastLetterIndex = new int[26];
        
        for(int i = 0; i < S.Length; i++)
        {
            var charIndex = S[i] - 'a';
            
            lastLetterIndex[charIndex] = i;
        }
        
        var visitedLetters = new HashSet<char>();
        int count = 0;
        
        int maxIndex = 0;
        
        for(int i = 0; i < S.Length; i++)
        {
            var currentCharIndex = S[i] - 'a';
            
            if(i > maxIndex) 
            {
                result.Add(count);
                count = 0;
            }
            
            maxIndex = Math.Max(lastLetterIndex[currentCharIndex], maxIndex);
            count++;
        }
        
        result.Add(count);
        
        return result;
    }
}