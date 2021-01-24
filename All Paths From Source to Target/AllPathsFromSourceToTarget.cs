public class Solution 
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) 
    {
        if(graph == null || graph.Length == 0 || graph[0].Length == 0) return null;
        
        var result = new List<IList<int>>();
        
        Backtracking(graph, result, new LinkedList<int>(), 0);
        
        return result;
    }
    
    private void Backtracking(int[][] graph, List<IList<int>> result, LinkedList<int> current, int vertice)
    {
        if(vertice == graph.Length - 1)
        {
            var newList = new List<int>(current);
            newList.Add(vertice);
            
            result.Add(newList);
            return;
        }
        
        current.AddLast(vertice);
              
        foreach(var adjacent in graph[vertice])
        {
            Backtracking(graph, result, current, adjacent);
        }
        
        current.RemoveLast();
    }
}