public class Solution 
{
    public IList<int> PartitionLabels(string S) 
    {
        var result = new List<int>();
        
        if(S == null || S.Length == 0) return result;
        
        var lastLetterIndex = new int[26];
        
        for(int i = 0; i < S.Length; i++)
        {           
            lastLetterIndex[S[i] - 'a'] = i;
        }
        
        int count = 0;
        // Store the highest index of the last character index
        int maxIndex = 0;
        
        for(int i = 0; i < S.Length; i++)
        {           
            if(i > maxIndex) 
            {
                result.Add(count);
                count = 0;
            }

            maxIndex = Math.Max(lastLetterIndex[S[i] - 'a'], maxIndex);
            count++;
        }
        
        result.Add(count);
        return result;
    }
}