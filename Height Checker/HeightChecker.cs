using System;

int HeightChecker(int[] heights) 
{
    // Copy values into a second array
    var sorted = new int[heights.Length];
    for(int i = 0; i < heights.Length; i++)
    {
        sorted[i] = heights[i];
    }
    
    // Insertion sort the second array
    for(int i = 0; i < sorted.Length; i++)
    {
        int k = i;
        
        while(k > 0 && sorted[k] < sorted[k - 1])
        {               
            var temp = sorted[k];
            
            sorted[k] = sorted[k - 1];
            
            sorted[k - 1] = temp;
            
            k--;
        }
    }
    
    // Count how many values are different between both arrays
    int count = 0;
    for(int i = 0; i < sorted.Length; i++)
    {           
        if(heights[i] != sorted[i])
        {
            count++;
        }
    }
    
    return count;
}