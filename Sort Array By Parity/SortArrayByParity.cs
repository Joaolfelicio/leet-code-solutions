public class Solution 
{
    public int[] SortArrayByParity(int[] A) 
    {
        var n = A.Length;
        
        if(A == null || n == 0) return A;
        
        var left = 0;
        var right = n - 1;
        
        while(right > left)
        {
            if(A[left] % 2 != 0)
            {
                Swap(A, left, right);
                right--;
            }
            else
            {
                left++;
            }
        }
        
        return A;
    }
    
    private void Swap(int[] A, int left, int right)
    {
        var temp = A[left];
        A[left] = A[right];
        A[right] = temp;
    }
}