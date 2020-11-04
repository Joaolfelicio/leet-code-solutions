using System;

bool ContainsDuplicate(int[] nums) 
{       
    //TODO: Implement the sort algorithm
    Array.Sort(nums);
    
    int p1 = 0;
    
    while(p1 < nums.Length - 1)
    {
        if(nums[p1] == nums[p1 + 1])
        {
            return true;
        }
        
        p1++;
    }
    
    return false;
}
