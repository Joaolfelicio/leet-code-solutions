using System;

int[] SmallerNumbersThanCurrent(int[] nums) 
{
    return SmallerNumbersThanCurrent(nums, new int[nums.Length], 0);
}

int[] SmallerNumbersThanCurrent(int[] nums, int[] result, int p1) 
{
    if(p1 >= nums.Length)
    {
        return result;
    }
    
    int sum = 0;
    
    for(int i = 0; i < nums.Length; i++)
    {
        if(nums[p1] > nums[i])
        {
            sum++;
        }
    }
    
    result[p1] = sum;
    
    return SmallerNumbersThanCurrent(nums, result, ++p1);
}