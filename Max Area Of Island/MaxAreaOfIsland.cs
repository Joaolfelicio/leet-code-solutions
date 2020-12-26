public class Solution 
{
    public int MaxAreaOfIsland(int[][] grid) 
    {
        if(grid == null || grid.Length == 0) return 0;
        
        int maxAreaIsland = 0;
        
        for(int i = 0; i < grid.Length; i++) 
        {
            for(int k = 0; k < grid[i].Length; k++)
            {
                if(grid[i][k] == 1)
                {
                    maxAreaIsland = Math.Max(maxAreaIsland, CountIslands(grid, i, k));
                }
            }
        }
        return maxAreaIsland;
    }
    
    private int CountIslands(int[][] grid, int i, int k)
    {
        if(i < 0 || i >= grid.Length || k < 0 || k >= grid[i].Length || grid[i][k] == 0)
        {
            return 0;
        }
        
        grid[i][k] = 0;
        
        int count = 1;
        
        count += CountIslands(grid, i + 1, k);
        count += CountIslands(grid, i - 1, k);
        count += CountIslands(grid, i, k + 1);
        count += CountIslands(grid, i, k - 1);
        
        return count;
    }
}