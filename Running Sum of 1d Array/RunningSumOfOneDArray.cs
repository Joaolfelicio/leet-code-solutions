using System;

int[] RunningSum(int[] nums) {
    int i = 1;
    
    return AddPrevious(nums, i);
}

int[] AddPrevious(int[] nums, int i)
{
    if(i >= nums.Length)
    {
        return nums;
    }
    
    nums[i] = nums[i] + nums[i - 1];
        
    return AddPrevious(nums, ++i);
}

