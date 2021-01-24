public class Solution 
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        if(target == 0 || candidates == null || candidates.Length == 0) return null;
    
        var result = new List<IList<int>>();
        
        Backtracking(result, new List<int>(candidates), new LinkedList<int>(), 0, target);
        
        return result;
    }
    
    private void Backtracking(List<IList<int>> result, List<int> candidates, LinkedList<int> output, int index, int remain)
    {
        if(remain == 0)
        {
            result.Add(new List<int>(output));
            return;
        }
        else if(remain < 0) return;
        
        for(int i = index; i < candidates.Count; i++)
        {
            output.AddLast(candidates[i]);
            Backtracking(result, candidates, output, i, remain - candidates[i]);
            output.RemoveLast();
        }
    }
}