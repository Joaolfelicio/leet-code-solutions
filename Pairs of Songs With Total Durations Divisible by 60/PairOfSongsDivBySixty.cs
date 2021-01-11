public class Solution {
    public int NumPairsDivisibleBy60(int[] time) 
    {
        if(time == null || time.Length == 0) return 0;
        
        var remainders = new int[60];
        var count = 0;
        
        foreach(var t in time)
        {
            if(t % 60 == 0)
            {
                count += remainders[0];
            }
            else
            {
                count += remainders[60 - t % 60];
            }
            remainders[t % 60]++;
        }
        return count;
    }
}