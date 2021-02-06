public class Solution 
{
    public bool Exist(char[][] board, string word) 
    {
        if(board == null || board.Length == 0 || board[0].Length == 0 || string.IsNullOrWhiteSpace(word)) 
            return false;
        
        for(int row = 0; row < board.Length; row++)
        {
            for(int col = 0; col < board[row].Length; col++)
            {
                if(board[row][col] == word[0] && Backtrack(board, word, 0, row, col)) 
                    return true;
            }
        }
        return false;
    }
    
    private bool Backtrack(char[][] board, string word, int index, int row, int col)
    {
        if(index == word.Length - 1)
        {
            return true;
        }
        
        var temp = board[row][col];
        board[row][col] = '0';

        foreach(var neighbour in GetNeighbours(board, word[index + 1], row, col))
        {
            if(Backtrack(board, word, index + 1, neighbour[0], neighbour[1])) return true;
        }
        
        board[row][col] = temp;
        return false;
    }
    
    private List<int[]> GetNeighbours(char[][] board, char neighbour, int row, int col)
    {
        var result = new List<int[]>();
        
        var directions = new int[][]
        {
            new int[] {0, 1},
            new int[] {1, 0},
            new int[] {0, -1},
            new int[] {-1, 0}
        };
        
        foreach(var dir in directions)
        {
            var newRow = row + dir[0];
            var newCol = col + dir[1];
            
            if(newRow < 0 || newRow >= board.Length || 
               newCol < 0 || newCol >= board[newRow].Length || 
               board[newRow][newCol] != neighbour) continue;
            
            result.Add(new int[] {newRow, newCol});
        }
        return result;
    }
}