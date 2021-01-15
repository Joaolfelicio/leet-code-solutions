public class Solution 
{
    public string MostCommonWord(string paragraph, string[] banned) 
    {
        var cleanParagraph = GetCleanParagraph(paragraph);
        
        var bannedWordsSet = new HashSet<string>(banned);
        
        var frequency = new Dictionary<string, int>();
        
        foreach(var word in cleanParagraph.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if(bannedWordsSet.Contains(word)) continue;
            
            frequency.TryGetValue(word, out var wordFreq); 
            frequency[word] = wordFreq + 1;
        } 
        return GetMostCommonWord(frequency);
    }
    
    private string GetCleanParagraph(string paragraph)
    {
        var result = new StringBuilder();
        
        for(var i = 0; i < paragraph.Length; i++)
        {
            var currentChar = Char.ToLower(paragraph[i]);
            
            if(currentChar >= 'a' && currentChar <= 'z') 
            {
                result.Append(currentChar);
            }
            else
            {
                result.Append(' ');
            }
        }
        return result.ToString();
    }
    
    private string GetMostCommonWord(Dictionary<string, int> dictionary)
    {
        var mostFrequentWord = string.Empty;
                
        foreach(var word in dictionary.Keys)
        {
            if(!dictionary.ContainsKey(mostFrequentWord) || dictionary[word] > dictionary[mostFrequentWord])
            {
                mostFrequentWord = word;
            }
        }
        return mostFrequentWord;
    }
}