public class Solution 
{
    public int FindPeakElement(int[] nums) 
    {
        if(nums.Length == 0) return -1;
        
        return FindPeakElement(nums, 0, nums.Length - 1);
    }
    
    private int FindPeakElement(int[] nums, int left, int right)
    {
        if(left == right) return left;
        
        int mid = left + (right - left) / 2;
        
        if(nums[mid] > nums[mid + 1])
        {
            return FindPeakElement(nums, left, mid);
        }
        else
        {
            return FindPeakElement(nums, mid + 1, right);
        }
    }
}