using System;

void Merge(int[] nums1, int m, int[] nums2, int n) 
{
    m--;
    n--;
    
    int i = nums1.Length - 1;
    
    while(i >= 0)
    {
        if(m < 0)
        {
            nums1[i] = nums2[n--];
        }
        else if(n < 0)
        {
            nums1[i] = nums1[m--];
        }
        else 
        {
            if(nums1[m] > nums2[n])
            {
                nums1[i] = nums1[m--];
            }
            else 
            {
                nums1[i] = nums2[n--];
            }
        }
        
        i--;
    }
}