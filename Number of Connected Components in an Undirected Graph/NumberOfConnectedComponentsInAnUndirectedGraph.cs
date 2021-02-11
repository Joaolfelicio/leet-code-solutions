public class Solution 
{
    public int CountComponents(int n, int[][] edges) 
    {        
        var graph = GetGraph(edges, n);
        
        var visited = new HashSet<int>();
        var connected = 0;
        
        for(int i = 0; i < n; i++)
        {
            if(visited.Contains(i)) continue;

            Transverse(i, graph, visited);
            connected++;
        }

        return connected;
    }
    
    private void Transverse(int node, Dictionary<int, List<int>> graph, HashSet<int> visited)
    {
        if(visited.Contains(node)) return;
        
        visited.Add(node);
        
        foreach(var edge in graph[node])
        {
            Transverse(edge, graph, visited);
        }
    }
    
    private Dictionary<int, List<int>> GetGraph(int[][] edges, int n)
    {       
        var graph = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < n; i++) graph[i] = new List<int>();
        
        foreach(var edge in edges)
        {           
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        
        return graph;
    }
}