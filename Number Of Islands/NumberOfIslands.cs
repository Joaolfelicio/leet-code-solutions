public class Solution 
{
    public int NumIslands(char[][] grid) 
    {
        var result = 0;
        
        if(grid == null || grid.Length == 0 || grid[0].Length == 0) return result;
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int k = 0; k < grid[i].Length; k++)
            {
                if(grid[i][k] == '1')
                {
                    result++;
                    TransverseIsland(i, k, grid);
                }
            }
        }
        return result;
    }
    
    private void TransverseIsland(int row, int column, char[][] grid)
    {
        if(row >= grid.Length || row < 0 || 
           column >= grid[row].Length || column < 0 || 
           grid[row][column] == '0')
        {
            return;
        }
        
        grid[row][column] = '0';
        
        TransverseIsland(row - 1, column, grid);
        TransverseIsland(row + 1, column, grid);
        TransverseIsland(row, column - 1, grid);
        TransverseIsland(row, column + 1, grid);
    }
}