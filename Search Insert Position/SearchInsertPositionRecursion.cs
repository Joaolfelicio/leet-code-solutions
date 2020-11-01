using System;

int SearchInsert(int[] nums, int target) {
        
    return binarySearch(nums, target, 0, nums.Length - 1);
}

int binarySearch(int[] nums, int target, int low, int high)
{
    var mid = (low + high) / 2;
    
    if(low >= high)
    {
        if(target > nums[mid])
        {
            return ++mid;
        }
        else
        {
            return mid;
        }
        return -1;
    }
            
    if(nums[mid] == target)
    {
        return mid;
    }
    else if(nums[mid] > target)
    {
        return binarySearch(nums, target, low, --mid);
    }
    else
    {
        return binarySearch(nums, target, ++mid, high);
    }
}