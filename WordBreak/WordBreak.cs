using System;

public bool WordBreak(string s, IList<string> wordDict) {
    
    bool[] arr = new bool[s.Length + 1];
    
    arr[0] = true;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(!arr[i]) 
        {
            continue;
        }
        
        foreach(var word in wordDict) 
        {
            if(i + word.Length < arr.Length) {

                if(s.Substring(i, word.Length) == word)
                {
                    arr[i + word.Length] = true; 
                }
            } 
        } 
    }
    
    return arr[arr.Length - 1];
}