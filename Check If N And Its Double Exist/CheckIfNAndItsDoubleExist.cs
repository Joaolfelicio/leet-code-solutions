using System;

bool CheckIfExist(int[] arr) 
{
    for(int i = 0; i < arr.Length; i++)
    {
        int j = 0;
        
        while(j < arr.Length)
        {               
            if(i != j && arr[i] * 2 == arr[j])
            {
                return true;
            }
            
            j++;
        }
    }
    
    return false;
}