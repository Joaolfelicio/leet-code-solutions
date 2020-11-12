using System;

int[] ReplaceElements(int[] arr) 
{
    int biggestValue = arr[arr.Length - 1];
    arr[arr.Length - 1] = -1;
    
    for(int i = arr.Length - 1; i > 0; i--)
    {
        if(biggestValue >= arr[i])
        {
            var temp = arr[i - 1];
            
            arr[i - 1] = biggestValue;
            
            if(temp > biggestValue)
            {
                biggestValue = temp; 
            }
        }
    }
    
    return arr;
}