using System;

int[] Shuffle(int[] nums, int n) 
{
    return ShuffleElems(nums, new int[nums.Length], n, 0, 0);
}

int[] ShuffleElems(int[] nums, int[] shuffleArray, int n, int p1, int p2)
{
    if(p2 > n - 1)
    {
        return shuffleArray;
    }
    
    shuffleArray[p1] = nums[p2];
    shuffleArray[++p1] = nums[p2 + n];
            
    return ShuffleElems(nums, shuffleArray, n, ++p1, ++p2);
}