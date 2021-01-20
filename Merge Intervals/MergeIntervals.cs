public class Solution 
{
    public int[][] Merge(int[][] intervals) 
    {
        if(intervals == null || intervals.Length == 0) return new int[0][];
     
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        
        var resultList = new List<int[]>();
        resultList.Add(intervals[0]);
        
        for(int i = 1; i < intervals.Length; i++)
        {           
            var lastMergeInterval = resultList.Count - 1;
            
            if(ShouldMerge(resultList[lastMergeInterval], intervals[i]))
            {
                resultList[lastMergeInterval][1] = Math.Max(intervals[i][1], resultList[lastMergeInterval][1]);
            }
            else
            {
                resultList.Add(intervals[i]);
            }
        }
               
        return resultList.ToArray();
    }
    
    private bool ShouldMerge(int[] interval1, int[] interval2) => interval1[1] >= interval2[0];
}