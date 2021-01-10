public class Solution {
    public int[][] KClosest(int[][] points, int K) 
    {
        var result = new int[K][];
                
        if(K == 0 || points == null || points.Length == 0) return result;
        
        var heap = new SortedDictionary<double, List<int[]>>();
        
        foreach(var point in points)
        {
            var distance = DistanceFromOrigin(point);
            
            if(heap.ContainsKey(distance)) 
            {
                heap[distance].Add(point);
            }
            else
            {
                heap.Add(distance, new List<int[]> { point });
            }
        }
        
	    int i = 0;
        
	    foreach (double key in heap.Keys) 
        {
            foreach (int[] point in heap[key]) 
            {
                if (i == K) break;
                result[i++] = point;
            }
        }
        
        return result;
    }
    
    private double DistanceFromOrigin(int[] point)
    {
        int xPow = point[0] * point[0];
        int yPow = point[1] * point[1];
        
        return Math.Sqrt(xPow + yPow);
    }
}