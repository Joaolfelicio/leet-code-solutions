public class Solution 
{
    public int[] PrisonAfterNDays(int[] cells, int N) 
    {
        if(cells == null || cells.Length == 0 || N <= 0) return cells;
        
        var hasCycle = false;
        var cycle = 0;
        var set = new HashSet<string>();
        
        for(int i = 0; i < N; i++)
        {
            var next = NextDay(cells);
            var key = string.Join(",", next);
            
            if(!set.Contains(key))
            {
                set.Add(key);
                cycle++;
            }
            else // We hit a cycle
            {
                hasCycle = true;
                break;
            }
            cells = next;
        }
        
        if(hasCycle)
        {
            N %= cycle;
            
            for(var i = 0; i < N; i++) cells = NextDay(cells);
        }
        return cells;
    }
    
    private int[] NextDay(int[] cells)
    {
        int[] tmp = new int[cells.Length];
        
        for(int i = 1; i < cells.Length - 1; i++)
        {
            tmp[i] = cells[i - 1] == cells[i + 1] ? 1 : 0;
        }
        return tmp;
    }
}