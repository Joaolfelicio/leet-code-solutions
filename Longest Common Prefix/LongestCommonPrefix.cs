using System;

string LongestCommonPrefix(string[] strs) 
{
    StringBuilder sb = new StringBuilder("");

    if(strs.Length == 0) 
    {
        return "";
    }
    
    for (int i = 0; i < strs[0].Length; i++)
    {
        char letter = strs[0][i];
        bool shouldBreak = false;

        for (int x = 1; x < strs.Length; x++)
        {
            if (i > strs[x].Length - 1 || letter != strs[x][i])
            {
                shouldBreak = true;
                break;
            }
        }
        
        if(shouldBreak) 
        {
            break;
        }

        sb.Append(letter);

    }

    return sb.ToString();
}
