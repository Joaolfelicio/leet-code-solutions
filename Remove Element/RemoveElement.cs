using System;

public int RemoveElement(int[] nums, int val) 
{
    int size = nums.Length;
    
    for(int i = 0; i < size; i++)
    {
        if(nums[i] == val)
        {
            nums[i] = nums[size - 1];
            size--;
            i--;
        }
    }
    
    return size;
}