using System;

bool CheckIfExist(int[] arr) 
{
    HashSet<float> hash = new HashSet<float>();
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(hash.Contains((float) arr[i] * 2) || hash.Contains((float) arr[i] / 2 ))
        {
            return true;
        }
        else
        {
            hash.Add((float) arr[i]);
        }
    }
    return false;
}