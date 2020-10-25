using System;

int RemoveDuplicates(int[] nums) 
{      
    if(nums.Length == 0)
    {
        return 0;
    }
    
    int i = 0;
    
    for(int k = 1; k < nums.Length; k++)
    {
        if(nums[k] != nums[i])
        {
            i++;
            nums[i] = nums[k];
        }
    }
    return i + 1;
}
