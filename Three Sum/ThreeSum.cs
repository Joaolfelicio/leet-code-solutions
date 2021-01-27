public class Solution 
{
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        var result = new List<IList<int>>();
        
        Array.Sort(nums);
        
        if(nums == null || nums.Length < 3) return result;
        
        for(int i = 0; i < nums.Length; i++)
        {
            // If ith of nums is bigger than 0, it's impossible to find three values that equal to 0, since they are ordered
            if(nums[i] > 0) break;
            
            // If it's not a duplicate from the previous ith of nums
            if(i == 0 || nums[i - 1] != nums[i]) AddComplements(nums, i, result);
        }
        return result;
    }
    
    private void AddComplements(int[] nums, int i, List<IList<int>> result)
    {
        var start = i + 1;
        var end = nums.Length - 1;
        
        while(start < end)
        {
            var sum = nums[i] + nums[start] + nums[end];
            
            if(sum < 0)
            {
                start++;
            }
            else if(sum > 0)
            {
                end--;
            }
            else
            {
                var list = new List<int>() {nums[i], nums[start++], nums[end--]};
                result.Add(list);
                
                // Skip the duplicates
                while(start < end && nums[start] == nums[start - 1]) start++;
            }
        }
    }
}