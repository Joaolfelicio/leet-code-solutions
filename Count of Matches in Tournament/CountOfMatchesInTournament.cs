public class Solution 
{
    public int NumberOfMatches(int n) 
    {
        var total = 0;
        
        while(n > 1)
        {
            if(n % 2 == 0)
            {
                total += n / 2;
                n /= 2;
            }
            else
            {
                total += (n - 1) / 2;
                n = (n + 1) / 2;
            }
        }
        return total;
    }
}