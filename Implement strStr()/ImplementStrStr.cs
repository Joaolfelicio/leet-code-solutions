using System;

int StrStr(string haystack, string needle) 
{
    if(String.IsNullOrEmpty(needle))
    {
        return 0;
    }
    
    int x = 0;
    int pos = -1;
    
    for(int i = 0; i < haystack.Length; i++)
    {                   
        if(haystack[i] == needle[x])
        {                               
            x++;
            
            if(pos == -1)
            {
                pos = i;
            }
        }
        else
        {
            if(pos != -1)
            {
                i -= x;
                pos = -1;
                x = 0;
            }
        }
                    
        if(x == needle.Length)
        {
            return pos;
        }
    }
    
    return -1;
}
