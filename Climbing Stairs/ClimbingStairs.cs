public class Solution 
{
    public int ClimbStairs(int n) 
    {
        var tabulation = new int[n + 1];
        
        tabulation[0] = 1;
        
        for(int i = 0; i < tabulation.Length; i++)
        {
            if(tabulation[i] != 0)
            {
                if(i + 1 < tabulation.Length) tabulation[i + 1] += tabulation[i];
                if(i + 2 < tabulation.Length) tabulation[i + 2] += tabulation[i];
            }
        }
        return tabulation[tabulation.Length - 1];
    }
}