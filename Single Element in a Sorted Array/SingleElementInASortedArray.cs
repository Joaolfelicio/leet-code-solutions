public class Solution 
{
    public int SingleNonDuplicate(int[] nums) 
    {
        if(nums == null || nums.Length == 0) return -1;
        
        var n = nums.Length;
        var left = 0;
        var right = n - 1;
        
        while(left <= right)
        {
            var mid = left + (right - left) / 2;
            var isHalfEven = (right - mid) % 2 == 0;
            
            if(left == right || (nums[mid - 1] != nums[mid] && nums[mid + 1] != nums[mid]))
            {
                return nums[mid];
            }
            if(nums[mid - 1] == nums[mid])
            {
                if(isHalfEven) right = mid - 2;
                else left = mid + 1;
            }
            else
            {
                if(isHalfEven) left = mid + 2;
                else right = mid - 1;
            }
        }
        return 0;
    }
}