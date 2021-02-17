public class Solution 
{
    public int[][] GenerateMatrix(int n) 
    {   
        var result = new int[n][];
        
        if(n == 0) return result;
       
        FillGrid(result, n);
        
        var left = 0;
        var right = n - 1;
        var top = 0;
        var bot = n - 1;
        var count = 1;
        
        while(left <= right)
        {
            for(int i = left; i <= right; i++)
            {
                result[top][i] = count++;
            }
            top++;
            
            for(int i = top; i <= bot; i++)
            {
                result[i][right] = count++;
            }
            right--;
            
            for(int i = right; i >= left; i--)
            {
                result[bot][i] = count++;
            }
            bot--;
            
            for(int i = bot; i >= top; i--)
            {
                result[i][left] = count++;
            }
            left++;
        }
        return result;
    }
    
    private void FillGrid(int[][] grid, int n)
    {
        for(int i = 0; i < grid.Length; i++)
        {
            grid[i] = new int[n];
        }
    }
}