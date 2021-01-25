public class Solution 
{
    public void SolveSudoku(char[][] board) 
    {
        if(board == null || board.Length == 0 || board[0].Length == 0) return;
    
        FillBoard(board, 0, 0);
    }
    
    private bool FillBoard(char[][] board, int row, int col)
    {
        for(int i = row; i < board.Length; i++, col = 0)
        {
            for(int j = col; j < board[i].Length; j++)
            {
                if(board[i][j] != '.') continue;
                
                for(char c = '1'; c <= '9'; c++)
                {
                    if(IsValid(board, i, j, c))
                    {
                        board[i][j] = c;

                        if(FillBoard(board, i, j + 1)) return true;
                        
                        board[i][j] = '.';
                    }
                }
                return false;
            }
        }
        return true;
    }
    
    private bool IsValid(char[][] board, int row, int col, char c)
    {
        for(int i = 0; i < 9; i++)
        {
            var rowMatrix = 3 * (row / 3) + i / 3;
            var colMatrix =  3 * (col / 3) + i % 3;
            
            if(board[i][col] == c || board[row][i] == c || 
               board[rowMatrix][colMatrix] == c) return false;
        }
        return true;
    }
}