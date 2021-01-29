public class Solution 
{
    public void Rotate(int[][] matrix) 
    {
        if(matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return;
        
        var n = matrix.Length - 1;
                
        for(int j = 0; j < matrix.Length / 2; j++)
        {
            for(int i = j; i < n - j; i++)
            {   
                // bot left
                var temp = matrix[n - i][j];
                
                // right bot to left bot
                matrix[n - i][j] = matrix[n - j][n - i];
                
                // top right to bot right
                matrix[n - j][n - i] = matrix[i][n - j];
            
                // top left to top right
                matrix[i][n - j] = matrix[j][i];
                
                // bot left to top left
                matrix[j][i] = temp;
            }
        }
    }
}