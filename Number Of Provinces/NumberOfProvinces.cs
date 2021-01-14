public class Solution 
{
    public int FindCircleNum(int[][] isConnected) 
    {
        if(isConnected == null || isConnected.Length == 0) return 0;
        
        var visited = new bool[isConnected.Length];
        int count = 0;
        
        for(int i = 0; i < isConnected.Length; i++)
        {           
            for(int j = 0; j < isConnected[i].Length; j++)
            {
                if(!visited[j] && isConnected[i][j] == 1) 
                {
                    count++;
                    Transverse(j, isConnected, visited);
                }
            }
        }
        return count;
    }
    
    public void Transverse(int index, int[][] graph, bool[] visited)
    {
        if(visited[index]) return;
        
        visited[index] = true;
        
        for(int j = 0; j < graph[index].Length; j++)
        {
            if(graph[index][j] == 1) 
                Transverse(j, graph, visited);
        }
    }
}