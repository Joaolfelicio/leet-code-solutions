public class Solution 
{
    public int ShortestPathBinaryMatrix(int[][] grid) 
    {
        if(grid == null || grid.Length == 0 || grid[grid.Length - 1][grid.Length - 1] == 1 || grid[0][0] == 1 ) return -1;
        
        var directions = new int[][]
        {
            new int[] {0, 1},
            new int[] {0, -1},
            new int[] {-1, 0},
            new int[] {1, 0},
            new int[] {-1, -1},
            new int[] {-1, 1},
            new int[] {1, 1},
            new int[] {1, -1}
        };
        
        var queue = new Queue<int[]>();
        queue.Enqueue(new int[] {0, 0});
        grid[0][0] = 1;
        
        while(queue.Count > 0 && grid[grid.Length - 1][grid.Length - 1] == 0)
        {
            var current = queue.Dequeue();
            var row = current[0];
            var col = current[1];
            int distance = grid[row][col];
                                   
            foreach(var neighbour in GetNeighbours(grid, directions, row, col))
            {
                var nRow = neighbour[0];
                var nCol = neighbour[1];
                
                grid[nRow][nCol] = distance + 1;
                queue.Enqueue(new int[] {nRow, nCol});
            }
        }      
        
        return grid[grid.Length - 1][grid.Length - 1] == 0 ? - 1 : grid[grid.Length - 1][grid.Length - 1];
    }
    
    private List<int[]> GetNeighbours(int[][] grid, int[][] directions, int row, int col)
    {
        var neighbours = new List<int[]>();
        
        foreach(var direction in directions)
        {
            var adjRow = row + direction[0];
            var adjCol = col + direction[1];

            if(adjRow < 0 || grid.Length <= adjRow || adjCol < 0 || grid[adjRow].Length <= adjCol || grid[adjRow][adjCol] != 0)
                continue;

            neighbours.Add(new int[] {adjRow, adjCol});
        }
        
        return neighbours;
    }
}