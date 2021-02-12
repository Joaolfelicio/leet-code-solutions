public class Solution 
{
    public string[] ReorderLogFiles(string[] logs) 
    {
        if(logs == null || logs.Length == 0)  return logs;   
                
        var (letterLogs, digitLogs) = FilterLogs(logs);
        
        SortLetterLogs(letterLogs);
        
        letterLogs.AddRange(digitLogs);
        
        return letterLogs.ToArray();
    }
    
    private void SortLetterLogs(List<string> letterLogs)
    {
        letterLogs.Sort((a, b) => 
        {
            var aContentSubstring = a.Substring(a.IndexOf(' '));
            var bContentSubstring = b.Substring(b.IndexOf(' '));
            
            var diff = aContentSubstring.CompareTo(bContentSubstring);
            
            if(diff != 0) return diff;
            
            var aIdSubstring = a.Substring(0, a.IndexOf(' '));
            var bIdSubstring = b.Substring(0, b.IndexOf(' '));
            
            return aIdSubstring.CompareTo(bIdSubstring);
        });
    }
    
    private (List<string>, List<string>) FilterLogs(string[] logs)
    {
        var letterLogs = new List<string>();
        var digitLogs = new List<string>();
        
        foreach(var log in logs)
        {
            var index = log.IndexOf(' ') + 1;
            
            if(log[index] >= 'a' && log[index] <= 'z')
            {
                letterLogs.Add(log);
            }
            else
            {
                digitLogs.Add(log);
            }
        }
        
        return (letterLogs, digitLogs);
    }
}