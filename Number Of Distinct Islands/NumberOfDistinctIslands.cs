public class Solution 
{
    public int NumDistinctIslands(int[][] grid) 
    {
        if(grid == null || grid.Length == 0) return 0;
        
        var islands = new HashSet<string>();
        
        for(int row = 0; row < grid.Length; row++)
        {
            for(int col = 0; col < grid[row].Length; col++)
            {
                if(grid[row][col] == 1)
                {
                    var sb = new StringBuilder();
                    TransverseIsland(grid, row, col, sb , "s");
                    
                    var sbStr = sb.ToString();
                    
                    if(!islands.Contains(sbStr)) islands.Add(sbStr);
                }
            }
        }
        return islands.Count;
    }
    
    private void TransverseIsland(int[][] grid, int row, int col, StringBuilder path, string direction)
    {
        if(row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length || grid[row][col] == 0)
        {
            return;
        }
        
        grid[row][col] = 0;
        path.Append(direction);
        
        TransverseIsland(grid, row - 1, col, path, "t");
        TransverseIsland(grid, row + 1, col, path, "b");
        TransverseIsland(grid, row, col - 1, path, "l");
        TransverseIsland(grid, row, col + 1, path, "r");
        
        path.Append("e");
    }
}


