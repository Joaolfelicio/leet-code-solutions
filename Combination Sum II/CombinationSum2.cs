public class Solution 
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) 
    {
        if(candidates == null || candidates.Length == 0) return null;
        
        var result = new List<IList<int>>();
        var output = new LinkedList<int>();
        
        Array.Sort(candidates);
        
        Backtracking(result, candidates, output, 0, target);
        
        return result;
    }
    
    private void Backtracking(List<IList<int>> result, int[] candidates, LinkedList<int> output, int index, int remainder)
    {
        if(remainder == 0)
        {
            result.Add(new List<int>(output));
            return;
        }
        else if(remainder < 0) return;
        
        for(int i = index; i < candidates.Length; i++)
        {
            if(i > index && candidates[i] == candidates[i - 1]) continue;
            
            output.AddLast(candidates[i]);
            Backtracking(result, candidates, output, i + 1, remainder - candidates[i]);
            output.RemoveLast();
        }
    }
}