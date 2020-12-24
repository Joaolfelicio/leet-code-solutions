public class Solution 
{
    public int NumIslands(char[][] grid) 
    {
        if(grid == null || grid.Length == 0) return 0;
        
        var numOfIslands = 0;
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    numOfIslands += Transverse(grid, i, j);
                }
            }
        }
        return numOfIslands;
    }
    
    private int Transverse(char[][] grid, int i, int j)
    {
        if(i >= grid.Length || i < 0 || j >= grid[i].Length || j < 0 || grid[i][j] == '0') 
        {
            return 0;
        }
        
        grid[i][j] = '0';
        
        //Transverse in the 4 directions
        Transverse(grid, i - 1, j);
        Transverse(grid, i + 1, j);
        Transverse(grid, i, j - 1);
        Transverse(grid, i, j + 1);
        
        return 1;
    }
}