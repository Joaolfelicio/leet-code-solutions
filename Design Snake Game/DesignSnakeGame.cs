public class SnakeGame 
{
    private int Width {get; }
    private int Height {get; }
    private int[][] Food {get; }
    private int FoodIndex {get; set;}
    private LinkedList<int[]> Snake {get; set;}
    private HashSet<string> Pieces {get; set;}
    
    /** Initialize your data structure here.
        @param width - screen width
        @param height - screen height 
        @param food - A list of food positions
        E.g food = [[1,1], [1,0]] means the first food is positioned at [1,1], the second is at [1,0]. */
    public SnakeGame(int width, int height, int[][] food) 
    {
        Width = width;
        Height = height;
        Food = food;
        FoodIndex = 0;
        Snake = new LinkedList<int[]>();
        Snake.AddFirst(new int[2] {0, 0});
        Pieces = new HashSet<string>();
        Pieces.Add("0,0");
    }
    
    /** Moves the snake.
        @param direction - 'U' = Up, 'L' = Left, 'R' = Right, 'D' = Down 
        @return The game's score after the move. Return -1 if game over. 
        Game over when snake crosses the screen boundary or bites its body. */
    public int Move(string direction) 
    {
        var head = Snake.First();
        var coord = GetCoordinates(direction);
        
        // Get the new coordinates
        var newRow = head[0] + coord[0];
        var newCol = head[1] + coord[1];
        
        // if it's outside bounds or colliding, we lose
        if(IsOutsideBounds(newRow, newCol) || IsColliding(newRow, newCol)) return -1;
                             
        MoveSnake(newRow, newCol, HasFood(newRow, newCol));
        
        return Snake.Count - 1;
    }
    
    private bool HasFood(int row, int col) => FoodIndex < Food.Length && Food[FoodIndex][0] == row && Food[FoodIndex][1] == col;
    
    private void MoveSnake(int row, int col, bool hasFoodToEat)
    {
        var last = Snake.Last;
        
        // Remove the last and add first piece to snake
        Snake.RemoveLast();
        Snake.AddFirst(new int[] {row, col});
        
        // Update the pieces hash set
        Pieces.Remove($"{last.Value[0]},{last.Value[1]}");
        Pieces.Add($"{row},{col}");
        
        // If it has food in that place, we need to add back the last piece of the snake
        if(hasFoodToEat) 
        {
            Snake.AddLast(last);
            Pieces.Add($"{last.Value[0]},{last.Value[1]}");
            
            FoodIndex++;
        }
    }
    
    private bool IsColliding(int row, int col)
    {
        // Check if any of those coordinates belong to our snake pieces, we don't care about the last piece
        // since we are moving the snake, we will remove the last part when moving
        if(row == Snake.Last.Value[0] && col == Snake.Last.Value[1]) return false; 
        
        return Pieces.Contains($"{row},{col}");
    }
    
    private bool IsOutsideBounds(int row, int col) => row < 0 || row >= Height || col < 0 || col >= Width;
    
    private int[] GetCoordinates(string direction)
    {
        var result = new int[2];
        
        switch(direction)
        {
            case "U":
                result[0] = -1;
                break;
            case "L":
                result[1] = -1;
                break;
            case "R":
                result[1] = 1;
                break;
            case "D":
                result[0] = 1;
                break;
        }
        return result;
    }
}

/**
 * Your SnakeGame object will be instantiated and called as such:
 * SnakeGame obj = new SnakeGame(width, height, food);
 * int param_1 = obj.Move(direction);
 */