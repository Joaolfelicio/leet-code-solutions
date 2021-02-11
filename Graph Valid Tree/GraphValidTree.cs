public class Solution 
{
    public bool ValidTree(int n, int[][] edges) 
    {
        if(n == 1) return true;
        if(edges.Length == 0 || edges.Length != n - 1) return false;
        
        var graph = GetGraph(edges, n);
        var visited = new HashSet<int>();
            
        return Transverse(0, -1, graph, visited) && visited.Count == n;
    }
    
    private bool Transverse(int node, int prevNode, Dictionary<int, List<int>> graph, HashSet<int> visited)
    {
        if(visited.Contains(node)) return false;
        
        visited.Add(node);
        
        foreach(var edge in graph[node])
        {
            if(prevNode == edge) continue;
            if(!Transverse(edge, node, graph, visited)) return false;
        }
        
        return true;
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