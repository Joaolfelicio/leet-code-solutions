using System;

public int FindNumbers(int[] nums) 
{
    return FindNumbers(nums, 0, 0);   
}

public int FindNumbers(int[] nums, int p1, int count)
{
    if(p1 >= nums.Length)
    {
        return count;
    }
    
    int digitsCount = (int) Math.Floor(Math.Log10(nums[p1]) + 1);
    
    if(digitsCount % 2 == 0)
    {
        count++;
    }
    in   
    return FindNumbers(nums, ++p1, count);
}