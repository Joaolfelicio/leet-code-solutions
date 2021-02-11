public class Solution 
{
    private int QuantityMoves {get; set;} = 0;
    
    public int UniquePathsIII(int[][] grid) 
    {
        if(grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;
        
        var squares = 0;
        int[] start = null;
        
        for(int row = 0; row < grid.Length; row++)
        {
            for(int col = 0; col < grid[row].Length; col++)
            {
                if(grid[row][col] >= 0) squares++;
                if(grid[row][col] == 1) start = new int[] {row, col};
            }
        }
        
        Backtrack(start[0], start[1], grid, squares);
        
        return QuantityMoves;
    }
    
    private void Backtrack(int row, int col, int[][] grid, int squares)
    {
        if(squares == 1 && grid[row][col] == 2)
        {
            QuantityMoves++;
            return;
        }
        else if(grid[row][col] == 2) return;

        var temp = grid[row][col];
        grid[row][col] = -1;
        
        squares--;
        
        foreach(var neighbour in GetNeighbours(row, col, grid))
        {
            Backtrack(neighbour[0], neighbour[1], grid, squares);
        }

        grid[row][col] = temp;
    }
    
    private List<int[]> GetNeighbours(int row, int col, int[][] grid)
    {
        var result = new List<int[]>();

        var directions = new int[][]
        {
            new int[]{0, 1},
            new int[]{1, 0},
            new int[]{0, -1},
            new int[]{-1, 0}
        };
        
        foreach(var dir in directions)
        {
            var newRow = row + dir[0];
            var newCol = col + dir[1];
            
            if(newRow < 0 || newRow >= grid.Length || 
               newCol < 0 || newCol >= grid[newRow].Length || 
               grid[newRow][newCol] < 0) continue;

            result.Add(new int[] {newRow, newCol});
        }
        return result;
    }
}