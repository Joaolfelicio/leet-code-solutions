using System;

int[] SortedSquares(int[] a) 
{
    int start = 0;
    int end = a.Length - 1;
    
    int[] sorted = new int[a.Length];
    
    for(int i = a.Length - 1; i >= 0; i--)
    {
        if(Math.Abs(a[start]) > Math.Abs(a[end]))
        {
            sorted[i] = a[start] * a[start];
            start++;
        }
        else
        {
            sorted[i] = a[end] * a[end];
            end--;
        }
    }
    
    return sorted;
}
