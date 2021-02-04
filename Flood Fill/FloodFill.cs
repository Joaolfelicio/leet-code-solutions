public class Solution 
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) 
    {
        if(image == null || image.Length == 0 || sr < 0 || sr >= image.Length || sc < 0 || sc >= image[sr].Length) return null;
        
        var queue = new Queue<int[]>();
        queue.Enqueue(new int[] {sr, sc});
        
        var directions = new int[][]
        {
            new int[] {0, 1},
            new int[] {1, 0},
            new int[] {0, -1},
            new int[] {-1, 0}
        };
        
        var initColor = image[sr][sc];
        
        while(queue.Count > 0)
        {
            var curr = queue.Dequeue();
            var row = curr[0];
            var col = curr[1];
            
            image[row][col] = newColor;
            
            foreach(var dir in directions)
            {
                var newRow = row + dir[0];
                var newCol = col + dir[1];
                
                if(newRow < 0 || newRow >= image.Length ||
                   newCol < 0 || newCol >= image[newRow].Length ||
                   image[newRow][newCol] == newColor || image[newRow][newCol] != initColor)
                    continue;
                
                queue.Enqueue(new int[] {newRow, newCol});
                
            }
        }
        return image;
    }
}