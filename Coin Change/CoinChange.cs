public class Solution 
{
    public int CoinChange(int[] coins, int amount) 
    {
        int maxValue = amount + 1;
        
        var tabulation = new int[maxValue];
        Array.Fill(tabulation, maxValue);
        
        tabulation[0] = 0;
        
        for(int i = 1; i < tabulation.Length; i++) 
        {           
            foreach(int coin in coins)
            {               
                if(i >= coin)
                {
                    tabulation[i] = Math.Min(tabulation[i], tabulation[i - coin] + 1);
                }
            }
        }
        return tabulation[tabulation.Length - 1] != maxValue ? tabulation[tabulation.Length - 1] : -1;
    }
}