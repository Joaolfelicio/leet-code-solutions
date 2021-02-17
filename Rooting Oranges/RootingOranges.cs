public class Solution 
{
    public int OrangesRotting(int[][] grid) 
    {
        if(grid == null || grid.Length == 0) return -1;
        
        var rottenOranges = new Queue<int[]>();
        
        var goodOranges = CountOranges(rottenOranges, grid);
        var minutes = 0;
        
        // If there are already no good oranges, it takes 0 minutes
        if(goodOranges == 0) return minutes;
        
        var orangeQuantity = goodOranges + rottenOranges.Count;
        
        while(rottenOranges.Count > 0)
        {
            var size = rottenOranges.Count;
            
            for(int i = 0; i < size; i++)
            {
                var current = rottenOranges.Dequeue();
                var row = current[0];
                var col = current[1];
                
                orangeQuantity--;
                
                foreach(var neighbour in GetNeighbours(row, col, grid))
                {
                    grid[neighbour[0]][neighbour[1]] = 2;
                    rottenOranges.Enqueue(neighbour);
                }
            }
            
            minutes++;
        }

        return orangeQuantity == 0 ? minutes - 1 : -1;
    }
    
    private List<int[]> GetNeighbours(int row, int col, int[][] grid)
    {
        var directions = new int[][]
        {
            new int[] {0, 1}, 
            new int[] {0, -1},
            new int[] {1, 0},
            new int[] {-1, 0}
        };
        
        var result = new List<int[]>();
        
        foreach(var dir in directions)
        {
            var newRow = row + dir[0];
            var newCol = col + dir[1];
            
            if(newRow < 0 || newRow >= grid.Length ||
               newCol < 0 || newCol >= grid[newRow].Length ||
               grid[newRow][newCol] != 1) continue;
            
            result.Add(new int[] {newRow, newCol});
        }
        
        return result;
    }
    
    private int CountOranges(Queue<int[]> rottenOranges, int[][] grid)
    {
        var counter = 0;
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                var curr = grid[i][j];
                
                if(curr == 1) counter++;
                else if(curr == 2) rottenOranges.Enqueue(new int[] {i, j});
            }
        }
        
        return counter;
    }
}