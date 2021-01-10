public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var complements = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            var complementVal = target - nums[i];
            
            if(complements.ContainsKey(complementVal))
            {
                return new int[2] {complements[complementVal], i};
            }
            
            complements.Add(nums[i], i);
        }
        
        return new int[0];
    }
}