public class Solution 
{
    public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website) 
    {  
        var map = new Dictionary<string, List<Pair>>();
        int n = username.Length;
        
        // Collect the website info for every user, key: username, value : timestamp and website
        for(int i = 0; i < n; i++)
        {
            if(!map.ContainsKey(username[i])) map.Add(username[i], new List<Pair>());
            map[username[i]].Add(new Pair(timestamp[i], website[i]));
        }
        
        
        // Count map to record every 3 combinations occuring time for the different user
        var count = new Dictionary<string, int>();
        
        string result = string.Empty;
        
        foreach(var key in map.Keys)
        {
            // Set to avoid visit the same 3-seq in one user
            var set = new HashSet<string>();
            
            var list = map[key];
            
            list.Sort((a, b) => a.Time - b.Time); // Sort by time
                
            // Brute force O(N^3)
            
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = i + 1; j < list.Count; j++)
                {
                    for(int k = j + 1; k < list.Count; k++)
                    {
                        var str = $"{list[i].Web} {list[j].Web} {list[k].Web}";
                        
                        if(!set.Contains(str))
                        {
                            count.TryGetValue(str, out var countResult);
                            
                            if(count.ContainsKey(str))
                            {
                                count[str] = countResult + 1;
                            }
                            else
                            {
                                count.Add(str, countResult + 1);
                            }
                            
                            set.Add(str);
                        }
                        if(result.Equals("") || count[result] < count[str] || 
                           count[result] == count[str] && result.CompareTo(str) > 0)
                        {
                            result = str;
                        }
                    }
                }
            }
        }
        var r = result.Split(" ");
        var finalResult = new List<string>();

        foreach(var str in r)
        {
            finalResult.Add(str);
        }
        return finalResult;
    }
}

public class Pair
{
    public int Time { get; set; }
    public string Web { get; set; }
    
    public Pair(int time, string web)
    {
        Time = time;
        Web = web;
    }
}