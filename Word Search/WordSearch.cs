public class Solution 
{
    public bool Exist(char[][] board, string word) 
    {
        if(board == null || string.IsNullOrEmpty(word) || board[0].Length == 0) return false;
        
        for(int row = 0; row < board.Length; row++)
        {
            for(int col = 0; col < board[row].Length; col++)
            {
                if(board[row][col] == word[0] && Backtracking(board, word, 0, row, col)) return true;
            }
        }
        return false;
    }
    
    private bool Backtracking(char[][] board, string word, int index, int row, int col)
    {
        // Once the index is the same as the word length, it means they are equal
        if(word.Length == index) return true;
        
        // Filter the positions out of bound, where the position is 0 and where it is not the same char value
        if(row < 0 || row >= board.Length || 
           col < 0 || col >= board[row].Length || 
           board[row][col] == '0' || board[row][col] != word[index]) 
            return false;
        
        // Change it temporarily to mark it as visited
        var temp = board[row][col];
        board[row][col] = '0';
        
        // Visit all the adjacent
        if(Backtracking(board, word, index + 1, row + 1, col) || Backtracking(board, word, index + 1, row - 1, col) ||
          Backtracking(board, word, index + 1, row, col + 1) || Backtracking(board, word, index + 1, row, col - 1))
            return true;
        
        // If its not equal, back track and put the initial value back
        board[row][col] = temp;
        return false;
    }
}