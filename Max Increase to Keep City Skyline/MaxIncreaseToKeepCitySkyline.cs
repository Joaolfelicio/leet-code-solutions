public class Solution 
{
    public int MaxIncreaseKeepingSkyline(int[][] grid) 
    {
        if(grid == null || grid.Length == 0) return 0;
        
        var initSum = 0;
        
        var horizontal = new int[grid.Length];
        var vertical = new int[grid.Length];
        
        for(int row = 0; row < grid.Length; row++)
        {
            for(int col = 0; col < grid[row].Length; col++)
            {
                initSum += grid[row][col];
                vertical[col] = Math.Max(grid[row][col], vertical[col]);
                horizontal[col] = Math.Max(grid[col][row], horizontal[col]);
            }
        }    

        var sum = 0;
        
        for(int row = 0; row < grid.Length; row++)
        {
            for(int col = 0; col < grid[row].Length; col++)
            {
                grid[row][col] = Math.Min(horizontal[col], vertical[row]);
                sum += grid[row][col];
            }
        }
        
        return sum - initSum;
    }
}