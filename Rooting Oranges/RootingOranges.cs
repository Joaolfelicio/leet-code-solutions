public class Solution 
{
    public int OrangesRotting(int[][] grid) 
    {
        if(grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;
        
        var rottenQueue = new Queue<OrangePosition>();
        
        // Validate the grid
        var freshCount = 0;
        
        for(int row = 0; row < grid.Length; row++)
        {
            for(int col = 0; col < grid[row].Length; col++)
            {
                if(grid[row][col] == 1)
                {
                    freshCount++;
                }
                else if(grid[row][col] == 2)
                {
                    rottenQueue.Enqueue(new OrangePosition(row, col));
                }
            }
        }
        
        if(freshCount == 0) return 0;
        if(rottenQueue.Count == 0) return -1;
        
        freshCount += rottenQueue.Count;
        
        var minutes = -1;        
        while(rottenQueue.Count > 0)
        {
            var size = rottenQueue.Count;
            
            for(int i = 0; i < size; i++)
            {
                var current = rottenQueue.Dequeue();
                var row = current.Row;
                var col = current.Col;
                
                freshCount--;
                
                AddRottenOrange(new OrangePosition(row - 1, col), grid, rottenQueue);
                AddRottenOrange(new OrangePosition(row + 1, col), grid, rottenQueue);
                AddRottenOrange(new OrangePosition(row, col - 1), grid, rottenQueue);
                AddRottenOrange(new OrangePosition(row, col + 1), grid, rottenQueue);
            }
            minutes++;
        }
        return freshCount == 0 ? minutes : -1;
    }
    
    private void AddRottenOrange(OrangePosition position, int[][] grid, Queue<OrangePosition> rottenQueue)
    {
        var row = position.Row;
        var col = position.Col;
        
        if(row < 0 || row >= grid.Length || col < 0 || col >= grid[row].Length || grid[row][col] != 1) return;
        
        grid[row][col] = 2;
        rottenQueue.Enqueue(position);
    }
}

public class OrangePosition
{
    public OrangePosition(int row, int col)
    {
        Row = row;
        Col = col;
    }
    
    public int Row {get; set;}
    public int Col {get; set;}
}