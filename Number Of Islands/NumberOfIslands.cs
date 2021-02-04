public class Solution 
{
    public int NumIslands(char[][] grid) 
    {
        if(grid == null || grid.Length == 0) return 0;
        
        var islands = 0;
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == '1') 
                {
                    TransverseIslands(grid, i, j);
                    islands++;
                }
            }
        }
        
        return islands;
    }
    
    private void TransverseIslands(char[][] grid, int row, int col)
    {
        if(row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length || grid[row][col] == '0')
            return;
        
        grid[row][col] = '0';
        
        TransverseIslands(grid, row + 1, col);
        TransverseIslands(grid, row - 1, col);
        TransverseIslands(grid, row, col + 1);
        TransverseIslands(grid, row, col - 1);
    }
}