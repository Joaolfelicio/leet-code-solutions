public class Solution {
    public IList<IList<int>> Subsets(int[] nums) 
    {
        var result = new List<IList<int>>();
        
        if(nums == null || nums.Length == 0) return result;
        
        Backtracking(nums, result, 0, new List<int>());

        return result;
    }
    
    private void Backtracking(int[] nums, List<IList<int>> result, int index, List<int> current)
    {
        if(index >= nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }
        
        current.Add(nums[index]);
        Backtracking(nums, result, index + 1, current);
        
        current.RemoveAt(current.Count - 1);
        Backtracking(nums, result, index + 1, current);
    }
}