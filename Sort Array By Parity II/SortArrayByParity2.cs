public class Solution 
{
    public int[] SortArrayByParityII(int[] A) 
    {
        int even = 0;
        int odd = 1;
        
        while(even < A.Length && odd < A.Length) 
        {
            if(A[even] % 2 != 0) 
            {
                Swap(A, even, odd);
                odd += 2;
            } 
            else 
            {
                even += 2;
            }
        }

        return A;
    }
    
    private void Swap(int[] arr, int even, int odd)
    {
        var temp = arr[even];
        arr[even] = arr[odd];
        arr[odd] = temp;
    }
}