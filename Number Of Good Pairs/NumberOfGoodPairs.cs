using System;

int NumIdenticalPairs(int[] nums) 
{
    return NumGoodPairs(nums, 0, 0, 1);
}

int NumGoodPairs(int[] nums, int sum, int p1, int p2)
{
    if(p1 >= nums.Length - 1 && p2 >= nums.Length - 1)
    {
        return sum;
    }
            
    if(nums[p1] == nums[p2] && p1 < p2)
    {
        sum++;
    }
    
    if(p2 == nums.Length - 1)
    {
        ++p1;
        p2 = p1;
    }
    
    return NumGoodPairs(nums, sum, p1, ++p2);
}