public class Solution 
{
    public int MaximumUnits(int[][] boxTypes, int truckSize) 
    {
        Array.Sort(boxTypes, ((a, b) => b[1] - a[1]));
        
        var sum = 0;
        var i = 0;
        
        while(truckSize > 0 && i < boxTypes.Length)
        {
            var curr = boxTypes[i];
            
            var boxCount = Math.Min(curr[0], truckSize);
            
            sum += (boxCount * curr[1]);
            truckSize -= boxCount;
            
            i++;
        }
        return sum;
    }
}