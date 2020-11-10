using System;

int FindMaxConsecutiveOnes(int[] nums) 
    {
        return FindMaxConsecutiveOnes(nums, 0, 0, 0);
    }
    
int FindMaxConsecutiveOnes(int[] nums, int p1, int currCount, int count)
{
    if(p1 >= nums.Length)
    {
        return Math.Max(currCount, count);
    }
    
    if(nums[p1] == 1)
    {
        currCount++;
    } 
    else
    {                  
        if(currCount > count)
        {
            count = currCount;
        }
        
        currCount = 0;
    }
    
    return FindMaxConsecutiveOnes(nums, ++p1, currCount, count);
}