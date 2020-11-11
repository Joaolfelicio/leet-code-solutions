using System;

public int RemoveElement(int[] nums, int val) 
{
    return RemoveElement(nums, val, 0, nums.Length);
}

private int RemoveElement(int[] nums, int val, int p1, int size)
{
    if(p1 >= size)
    {
        return size;
    }

    if(nums[p1] == val)
    {
        nums[p1] = nums[size - 1];
        size--;
    }
    else
    {
        p1++;
    }

    return RemoveElement(nums, val, p1, size);
}