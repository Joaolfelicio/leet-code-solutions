public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        if(prices == null || prices.Length == 0) return 0;

        var min = Int32.MaxValue;
        var max = 0;
        
        for(int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            max = Math.Max(max, prices[i] - min);
        }
 
        return max;
    }
}