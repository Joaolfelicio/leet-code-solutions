public class Solution 
{
    public IList<IList<int>> Permute(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return null;
        
        var result = new List<IList<int>>();
        
        Backtracking(result, new List<int>(nums), new List<int>());
        
        return result;
    }
    
    private void Backtracking(List<IList<int>> result, List<int> available, List<int> current)
    {
        if(available.Count == 0)
        {
            result.Add(new List<int>(current));
            return;
        }
        
        for(int i = 0; i < available.Count; i++)
        {
            var availableCopy = new List<int>(available);
            
            current.Add(available[i]);
            availableCopy.RemoveAt(i);
            
            Backtracking(result, availableCopy, current);
            
            current.RemoveAt(current.Count - 1);
        }
    }
}