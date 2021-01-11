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
        
        for(int i = 0; i < S.Length; i++)
        {
            var shouldPartition = true;
            
            if(!visitedLetters.Contains(S[i]))
            {              
                foreach(var visitedChar in visitedLetters)
                {
                    var lastIndexChar = lastLetterIndex[visitedChar - 'a'];
                    
                    if(i <= lastIndexChar) 
                    {
                        shouldPartition = false;
                        break;
                    }
                }
                
                if(shouldPartition && visitedLetters.Count > 0)
                {
                    result.Add(count);
                    count = 0;
                    visitedLetters.Clear();
                } 
                visitedLetters.Add(S[i]);
            }

            count++;
        }
        
        if(count > 0) result.Add(count);
        
        return result;
    }
}