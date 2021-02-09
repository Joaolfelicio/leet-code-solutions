public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        var result = new List<IList<int>>();
        
        if(numRows <= 0) return result;
        
        var n = 1;
        List<int> prev = null;
        
        while(numRows >= n)
        {
            var level = new List<int>(n);
            
            for(int i = 0; i < n; i++)
            {
                if(i == 0 || i == n - 1)
                {
                    level.Add(1);
                }
                else
                {
                    level.Add(prev[i - 1] + prev[i]);
                }
            }
            
            result.Add(level);
            prev = level;
            n++;
        }

        return result;
    }
}