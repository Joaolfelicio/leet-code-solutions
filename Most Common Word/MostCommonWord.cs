public class Solution 
{
    public string MostCommonWord(string paragraph, string[] banned) 
    {
        if(string.IsNullOrWhiteSpace(paragraph)) return string.Empty;
        
        var bannedWords = new HashSet<string>(banned);
        var cleanPara = CleanParagraph(paragraph);
        
        var cleanWords = cleanPara.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        
        var commonWord = string.Empty;
        var repetition = new Dictionary<string, int>();
        
        foreach(var word in cleanWords)
        {
            if(bannedWords.Contains(word)) continue;
            
            repetition.TryGetValue(word, out var quantity);
            repetition[word] = quantity + 1;
            
            if(commonWord == string.Empty || repetition[word] > repetition[commonWord]) 
                commonWord = word;
        }
        
        return commonWord;
    }
    
    private string CleanParagraph(string paragraph)
    {
        var sb = new StringBuilder();
        
        for(int i = 0; i < paragraph.Length; i++)
        {
            var c = Char.ToLower(paragraph[i]);
            
            if(c == ' ' || c >= 'a' && c <= 'z') sb.Append(Char.ToLower(c));
            else if(c == ',') sb.Append(' ');
        }
        
        return sb.ToString();
    }
}