using System;

int SearchInsert(int[] nums, int target) {
    int low = 0;
    int high = nums.Length - 1;
    int currentIndex = -1;
    
    while(high >= low)
    {          
        currentIndex = (low + high) / 2;
                    
        if(nums[currentIndex] == target)
        {
            return currentIndex;
        }
        else if(target > nums[currentIndex])
        {               
            low = currentIndex + 1;
        } 
        else
        {
            high = currentIndex - 1;
        }
    }
    
    if(nums[currentIndex] < target)
    {
        return currentIndex + 1;
    } 
    else
    {
        return currentIndex;
    }
}
