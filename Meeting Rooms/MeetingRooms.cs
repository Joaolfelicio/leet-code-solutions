public class Solution 
{
    public bool CanAttendMeetings(int[][] intervals) 
    {
        if(intervals == null || intervals.Length == 0) return true;
        
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        
        var prevEnd = intervals[0][1];
        
        for(int i = 1; i < intervals.Length; i++)
        {        
            if(prevEnd > intervals[i][0]) return false;
            
            prevEnd = intervals[i][1];
        }
        
        return true;
    }
}