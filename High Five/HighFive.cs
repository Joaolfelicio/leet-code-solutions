public class Solution 
{
    public int[][] HighFive(int[][] items) 
    {
        if(items == null || items.Length == 0) return new int[0][];
               
        Array.Sort(items, (a, b) =>
        {    
           if(a[0] - b[0] != 0) return a[0] - b[0];
           return b[1] - a[1];
        });
        
        var result = new List<int[]>();
        
        var sum = 0;
        var finishedStudent = -1;
        var topIndex = 5;
        
        for(int i = 0; i < items.Length; i++)
        {
            if(items[i][0] == finishedStudent) continue;
            
            topIndex--;
            sum += items[i][1];
            
            if(topIndex == 0)
            {
                result.Add(new int[] {items[i][0], (sum / 5)});
                topIndex = 5;
                sum = 0;
                finishedStudent = items[i][0];
            }
        }
        
        return result.ToArray();
    }
}