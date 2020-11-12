using System;

int[] SortArrayByParity(int[] A) 
{
    int p1 = 0;
    int p2 = A.Length - 1;
    
    while(p1 != p2)
    {
        if(A[p1] % 2 == 0)
        {
            p1++;
        }
        else
        {
            if(A[p2] % 2 == 0)
            {
                int temp = A[p1];
                
                A[p1] = A[p2];
                A[p2] = temp;
            }
            p2--;
        }
    }
    return A;
}