public class Solution 
{
    public bool JudgeCircle(string moves) 
    {
        if(string.IsNullOrWhiteSpace(moves)) return true;
        
        var row = 0;
        var col = 0;
        
        foreach(var move in moves)
        {
            if(move == 'U') row--;
            else if(move == 'D') row++;
            else if(move == 'L') col--;
            else col++;
        }
        
        return row == 0 && col == 0;
    }
}