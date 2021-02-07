public class Solution 
{
    public int MinMeetingRooms(int[][] intervals) 
    {
        if(intervals == null || intervals.Length == 0) return 0;
        
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        
        var duplicates = 0;
        
        var rooms = new SortedSet<int>();
        rooms.Add(intervals[0][1]);   
        
        for(int i = 1; i < intervals.Length; i++)
        {
            var firstRoom = rooms.Min;
            var currInterval = intervals[i];
            
            if(firstRoom <= currInterval[0])
            {
                 rooms.Remove(firstRoom);
            }
            
            if(!rooms.Add(currInterval[1])) duplicates++;
        }
        
        return rooms.Count + duplicates;
    }
}