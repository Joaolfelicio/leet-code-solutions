public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {
        if(board == null || board.Length == 0 || board[0].Length == 0) return false;
        
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                if(!IsValidCell(board, i, j)) return false;
            }
        }
        return true;
    }
    
    private bool IsValidCell(char[][] board, int row, int col)
    {
        var c = board[row][col];
        if(c == '.') return true;
        
        for(int i = 0; i < board.Length; i++)
        {   
            var rowMatrix =  3 * (row / 3) + i / 3;
            var colMatrix =  3 * (col / 3) + i % 3;
            
            if(i != row && board[i][col] == c) return false;
            if(i != col && board[row][i] == c) return false;
            if(row != rowMatrix && col != colMatrix && board[rowMatrix][colMatrix] == c) return false;
        }
        
        return true;
    }
}