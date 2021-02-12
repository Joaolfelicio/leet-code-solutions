public class Solution 
{
    public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website) 
    {          
        var userVisits = GetVisitInfos(username, timestamp, website);
        
        // Count userVisits to record every 3 combinations occuring time for the different user
        var count = new Dictionary<string, int>();
        
        string result = string.Empty;
        
        foreach(var userVisit in userVisits.Keys)
        {
            // Set to avoid visit the same 3-seq in one user
            var set = new HashSet<string>();
            
            var list = userVisits[userVisit];
            
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
                        
                        if(result.Equals("") || count[result] < count[str] || count[result] == count[str] && result.CompareTo(str) > 0) 
                            result = str;
                    }
                }
            }
        }
        
        var r = result.Split(" ");
        
        return r.ToList();
    }
    
    private Dictionary<string, List<VisitInfo>> GetVisitInfos(string[] username, int[] timestamp, string[] website)
    {
        var map = new Dictionary<string, List<VisitInfo>>();
        
        // Collect the website info for every user, key: username, value : timestamp and website
        for(int i = 0; i < username.Length; i++)
        {
            if(!map.ContainsKey(username[i])) map.Add(username[i], new List<VisitInfo>());
            map[username[i]].Add(new VisitInfo(timestamp[i], website[i]));
        }
        
        return map;
    }
}

public class VisitInfo
{
    public int Time { get; set; }
    public string Web { get; set; }
    
    public VisitInfo(int time, string web)
    {
        Time = time;
        Web = web;
    }
}