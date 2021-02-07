public class Solution 
{
    public int CoinChange(int[] coins, int amount) 
    {
        if(coins == null || coins.Length == 0 || amount == 0) return 0;
        
        var table = new int[amount + 1];
        
        Array.Fill(table, -1);
        
        table[0] = 0;
        
        for(int i = 0; i < table.Length; i++)
        {
            if(table[i] == -1) continue;
            
            foreach(var coin in coins)
            {
                if(i + coin >= table.Length || coin > amount) continue;

                if(table[i + coin] == -1) table[i + coin] = table[i] + 1;
                else table[i + coin] = Math.Min(table[i] + 1, table[i + coin]);       
            }
        }
        return table[table.Length - 1];
    }
}