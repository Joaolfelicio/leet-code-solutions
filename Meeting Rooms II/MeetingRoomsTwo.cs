public class Solution 
{
    public int MinMeetingRooms(int[][] intervals) 
    {   
        if(intervals == null) return 0;
     
        var duplicates = 0;
        
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        
        var rooms = new SortedSet<int>();

        rooms.Add(intervals[0][1]);
        
        for(int i = 1; i < intervals.Length; i++)
        {
            var current = intervals[i];
            
            if(current[0] >= rooms.Min)
            {
                rooms.Remove(rooms.Min);
            }
            
            if(!rooms.Contains(intervals[i][1]))
            {
                rooms.Add(intervals[i][1]);
            }
            else
            {
                duplicates++;
            }
        }
        return rooms.Count + duplicates;
    }
}
