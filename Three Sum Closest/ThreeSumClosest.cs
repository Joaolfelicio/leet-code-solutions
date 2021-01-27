public class Solution 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {   
        if(nums == null || nums.Length < 3) return 0;
        
        Array.Sort(nums);
        
        var closestDifference = Int32.MaxValue;
        var sumClosest = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            var start = i + 1;
            var end = nums.Length - 1;
            
            while(start < end)
            {
                var sum = nums[i] + nums[start] + nums[end];
                
                var difference = Math.Abs(target - sum);
                
                if(difference < closestDifference)
                {
                    closestDifference = difference;
                    sumClosest = sum;
                }
                
                if(sum > target) end--;
                else if(sum < target) start++;
                else return target;
            }
        }
        return sumClosest;
    }
}