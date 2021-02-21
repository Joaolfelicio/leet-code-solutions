public class Solution 
{
    public bool IsArmstrong(int N) 
    {
        return N == CalculateArmstrong(N, (int) Math.Log10(N) + 1);
    }
    
    private int CalculateArmstrong(int n, int length)
    {
        var result = 0;
        
        while(n > 0)
        {
            result += (int) Math.Pow(n % 10, length);
            n /= 10;
        }
        
        return result;
    }
}