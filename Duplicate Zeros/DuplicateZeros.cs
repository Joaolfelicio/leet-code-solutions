using System;

public void DuplicateZeros(int[] arr) 
{
    int zeros = 0;
    
    foreach(int elem in arr)
    {
        if(elem == 0) zeros++;
    }
    
    int low = arr.Length - 1;
    int high = arr.Length - 1 + zeros;
    
    while(low != high)
    {
        insert(arr, low, high--);
        
        if(arr[low] == 0)
        {
            insert(arr, low, high--);
        }
        
        low--;
    }
}

private void insert(int[] arr, int low, int high)
{
    if(high < arr.Length)
    {
        arr[high] = arr[low];
    }
}
