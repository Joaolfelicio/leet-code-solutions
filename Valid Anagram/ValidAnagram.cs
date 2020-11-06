using System;

bool IsAnagram(string s, string t) 
{
    if(s.Length != t.Length)
    {
        return false;
    }
    
    //TODO: Create the sort algorithm
    char[] sArr = s.ToArray();
    Array.Sort(sArr);
    s = new string(sArr);
    
    char[] tArr = t.ToArray();
    Array.Sort(tArr);
    t = new string(tArr);
    
    return s == t;
}