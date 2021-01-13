public class Solution 
{
    public IList<string> TopKFrequent(string[] words, int k) 
    {
        var result = new List<string>(k);
        
        var frequency = new Dictionary<string, int>();
        
        foreach(var word in words)
        {
            if(frequency.ContainsKey(word))
            {
                frequency[word]++;
            }
            else
            {
                frequency.Add(word, 1);
            }
        }
        
        return frequency
            .OrderByDescending(x => x.Value)
            .ThenBy(y => y.Key)
            .Select(z => z.Key)
            .Take(k)
            .ToList();
    }
}