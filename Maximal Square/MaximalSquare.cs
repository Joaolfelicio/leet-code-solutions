public class Solution 
{
    public int MaximalSquare(char[][] matrix) 
    {
        var rows = matrix.Length;
        var cols = rows > 0 ? matrix[0].Length : 0;
        
        var dp = new int[cols + 1];
        
        var maxsqlen = 0;
        var prev = 0;
        
        for(var i = 1; i <= rows; i++)
        {
            for(var j = 1; j <= cols; j++)
            {
                var temp = dp[j];
                
                if(matrix[i - 1][j - 1] == '1')
                {
                    dp[j] = Math.Min(Math.Min(dp[j - 1], prev), dp[j]) + 1;
                    maxsqlen = Math.Max(maxsqlen, dp[j]);
                }
                else
                {
                    dp[j] = 0;
                }
                prev = temp;
            }
        }
        return maxsqlen * maxsqlen;
    }
}
