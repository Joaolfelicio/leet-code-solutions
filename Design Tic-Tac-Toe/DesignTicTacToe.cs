public class TicTacToe 
{
    private int[] Horizontal {get; set;}
    private int[] Vertical {get; set;}
    private int TopLeftDiag {get; set;}
    private int BotLeftDiag {get; set;}
    
    /** Initialize your data structure here. */
    public TicTacToe(int n) 
    {
        Horizontal = new int[n];
        Vertical = new int[n];
        TopLeftDiag = 0;
        BotLeftDiag = 0;
    }
    
    /** Player {player} makes a move at ({row}, {col}).
        @param row The row of the board.
        @param col The column of the board.
        @param player The player, can be either 1 or 2.
        @return The current winning condition, can be either:
                0: No one wins.
                1: Player 1 wins.
                2: Player 2 wins. */
    public int Move(int row, int col, int player) 
    {       
        var playerValue = player == 1 ? 1 : -1;
        
        Horizontal[col] += playerValue;
        Vertical[row] += playerValue;
        if(row == col) TopLeftDiag += playerValue;
        if(row + col == Horizontal.Length - 1) BotLeftDiag += playerValue; 

        if(UserWon(row, col, player)) return player;
        
        return 0;
    }
    
    private bool UserWon(int row, int col, int player)
    {
        return IsRowWinner(row) || IsColWinner(col) || IsFullDiagonal();
    }
    
    private bool IsRowWinner(int row) => Math.Abs(Vertical[row]) == Vertical.Length;
    
    private bool IsColWinner(int col) => Math.Abs(Horizontal[col]) == Horizontal.Length;
    
    private bool IsFullDiagonal() => Math.Abs(TopLeftDiag) == Horizontal.Length || Math.Abs(BotLeftDiag) == Horizontal.Length;
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */