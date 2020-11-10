using System;

public int[] SortedSquares(int[] a) 
    {
        return SortedSquares(a, 0);    
    }
    
int[] SortedSquares(int[] a, int p1)
{
    if(p1 >= a.Length)
    {
        return SortArray(a);
    }
    
    a[p1] = a[p1] * a[p1];
    
    return SortedSquares(a, ++p1);
}

//Insertion sort
int[] SortArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        int current = i;

        while(current > 0 && a[current] < a[current - 1])
        {
            var temp = a[current - 1];
            a[current - 1] = a[current];
            a[current] = temp;
            
            current--;
        }
    }
    return a;
}

