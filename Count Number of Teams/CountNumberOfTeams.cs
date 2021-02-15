public class Solution 
{
    public int NumTeams(int[] rating) 
    {
        var count = 0;
        
        for(int i = 0; i < rating.Length; i++)
        {
            var leftSmaller = 0;
            var rightSmaller = 0;
            
            var rightBigger = 0;
            var leftBigger = 0;
            
            for(int j = 0; j < i; j++)
            {
                if(rating[i] < rating[j]) leftBigger++;
                if(rating[i] > rating[j]) leftSmaller++;
            }
            
            for(int j = i + 1; j < rating.Length; j++)
            {
                if(rating[i] < rating[j]) rightBigger++;
                if(rating[i] > rating[j]) rightSmaller++;
            }
            
            count += leftSmaller * rightBigger + leftBigger * rightSmaller;
        }
        
        return count;
    }
}