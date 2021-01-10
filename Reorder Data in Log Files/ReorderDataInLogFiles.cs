public class Solution 
{
    public string[] ReorderLogFiles(string[] logs) 
    {
        List<string> letterLogs = new List<string>(); 
        List<string> digitLogs = new List<string>();
        
        foreach (var log in logs)
        {
            if (char.IsDigit(log[log.IndexOf(' ') + 1]))
            {
                digitLogs.Add(log);
            }
            else
            {
                letterLogs.Add(log);
            }
        }

        letterLogs.Sort((a, b) =>
        {
            string a_substr = a.Substring(a.IndexOf(' ') + 1);
            
            string b_substr = b.Substring(b.IndexOf(' ') + 1);
            
            var result = a_substr.CompareTo(b_substr);
            if (result == 0)
            {
                result = a.Substring(0, a.IndexOf(' ')).CompareTo(b.Substring(0, b.IndexOf(' ')));
            }
            return result;
        });

        letterLogs.AddRange(digitLogs);
        return letterLogs.ToArray(); 
    }
}