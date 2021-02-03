public class Solution 
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) 
    {
        if(wordList == null || wordList.Count == 0) return 0;
        
        var wordSet = GetWordsSet(wordList);
        
        if(!wordSet.Contains(endWord)) return 0;
        var result = 1;
        
        var wordsQueue = new Queue<string>();
        wordsQueue.Enqueue(beginWord);
        
        while(wordsQueue.Count > 0 )
        {
            var size = wordsQueue.Count;
            
            for(int i = 0; i < size; i++)
            {
                var word = wordsQueue.Dequeue();

                if(word.Equals(endWord)) return result;
                
                foreach(var neighbour in GetNeighbours(word, wordSet))  
                    wordsQueue.Enqueue(neighbour);
            }   
            result++;
        }
        return 0;
    }
    
    private List<string> GetNeighbours(string word, HashSet<string> wordSet)
    {
        var result = new List<string>();
        var wordArr = word.ToCharArray();
        
        for(int j = 0; j < wordArr.Length; j++)
        {
            for(int k = 0; k < 26; k++)
            {
                var c = (char) (k + 'a');
                
                var temp = wordArr[j];
                
                wordArr[j] = c;

                var possibleStr = new String(wordArr);
                
                if(wordSet.Contains(possibleStr)) 
                {
                    result.Add(possibleStr);
                    wordSet.Remove(possibleStr);
                }
                
                wordArr[j] = temp;
            }
            wordSet.Remove(word);
        }
        return result;
    }
    
    private HashSet<string> GetWordsSet(IList<string> wordList)
    {
        var result = new HashSet<string>();
        
        foreach(var word in wordList) result.Add(word);
        
        return result;
    }
}