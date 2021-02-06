public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        if(nums == null || nums.Length == 0) return -1;
        
        var left = 0;
        var right = nums.Length - 1;
        
        while(right >= left)
        {
            var mid = (right - left) / 2 + left;
            
            var leftVal = nums[left];
            var rightVal = nums[right];
            var midVal = nums[mid];
            
            if(midVal == target) return mid;
            else if(midVal >= leftVal)
            {
                if(target >= leftVal && target < midVal) right = mid - 1;
                else left = mid + 1;
            }
            else
            {
                if(target <= rightVal && target > midVal) left = mid + 1;
                else right = mid - 1;
            }
        }
        return -1;
    }
}