public class Solution 
{
    public int[][] Merge(int[][] intervals) 
    {
        if(intervals == null || intervals.Length == 0 || intervals[0].Length == 0)
            return new int[0][];
        
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        
        var result = new List<int[]>();
        result.Add(intervals[0]);
        
        for(int i = 1; i < intervals.Length; i++)
        {
            var lastInterval = result[result.Count - 1];
            var currInterval = intervals[i];
            
            if(lastInterval[1] >= currInterval[0]) 
                lastInterval[1] = Math.Max(lastInterval[1], currInterval[1]);
            else result.Add(currInterval);
        }
        return result.ToArray();
    }
}