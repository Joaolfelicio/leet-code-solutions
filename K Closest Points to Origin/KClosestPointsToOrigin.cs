public class Solution 
{
    public int[][] KClosest(int[][] points, int K) 
    {
        var result = new int[K][];
        
        if(points == null || points.Length == 0 || K == 0) return result;
        
        var orderedPoints = GetOrderedPoints(points);
        
        foreach(var distance in orderedPoints.Keys)
        {
            foreach(var values in orderedPoints[distance])
            {
                result[--K] = values;
                if(K <= 0) return result;
            }   
        }
        
        return result;
    }
    
    private SortedDictionary<int, List<int[]>> GetOrderedPoints(int[][] points)
    {
        var orderedPoints = new SortedDictionary<int, List<int[]>>();
        
        foreach(var point in points)
        {
            var distance = CalculateDistance(point);
            
            if(orderedPoints.ContainsKey(distance)) 
                orderedPoints[distance].Add(point);
            else
                orderedPoints[distance] = new List<int[]>() {point};
        }
        return orderedPoints;
    }
    
    private int CalculateDistance(int[] point) => point[0] * point[0] + point[1] * point[1];
}