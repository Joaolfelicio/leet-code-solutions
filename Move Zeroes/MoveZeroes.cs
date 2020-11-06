using System;

void MoveZeroes(int[] nums) 
{
    ExchangeZeroes(nums, 0, 0);
}

void ExchangeZeroes(int[] nums, int p1, int zeroCount)
{
    if(p1 >= nums.Length - zeroCount)
    {
        return;
    }
    
    if(nums[p1] == 0)
    {
        zeroCount++;
        
        for(int i = p1; i < nums.Length - zeroCount; i++)
        {
            nums[i] = nums[i + 1]; 
        }
        
        nums[nums.Length - zeroCount] = 0;
    }
    else
    {
        p1++;
    }
    
    ExchangeZeroes(nums, p1, zeroCount);
}

