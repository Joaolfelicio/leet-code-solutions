using System;

bool ValidMountainArray(int[] arr) 
{
    int i = 0;
    
    // Climb until the peak
    while(i + 1 < arr.Length && arr[i] < arr[i + 1])
    {
        i++;
    }
    
    // The peak cant be in the beggining or in the end
    if(i == 0 || i == arr.Length - 1)
    {
        return false;
    }
    
    // Descend until the end of the montain
    while(i + 1 < arr.Length && arr[i] > arr[i + 1])
    {
        i++;
    }
    
    return i == arr.Length - 1;
}
