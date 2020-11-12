using System;

IList<int> FindDisappearedNumbers(int[] nums) 
{
    var list = new List<int>();
    
    // If the value is in the array "flag it" by making it negative
    for(int i = 0; i < nums.Length; i++)
    {
        nums[Math.Abs(nums[i]) - 1] = - Math.Abs(nums[Math.Abs(nums[i]) - 1]);
    }
    
    // If the number is positive, it means it's not in the array
    for(int i = 0; i < nums.Length; i++)
    {
        if(nums[i] > 0)
        {
            list.Add(i + 1);
        }
    }
    
    return list;
}