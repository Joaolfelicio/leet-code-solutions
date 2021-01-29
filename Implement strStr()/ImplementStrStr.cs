public class Solution {
    public int StrStr(string haystack, string needle) 
    {
        if(String.IsNullOrEmpty(needle)) return 0;
        if(needle.Length > haystack.Length) return -1;
        
        var hsPointer = 0;
        var needlePointer = 0;
        var startingIndex = -1;
        
        while(hsPointer < haystack.Length && needlePointer < needle.Length)
        {
            // If it's equal, incrase needle pointer
            if(haystack[hsPointer] == needle[needlePointer])
            {
                // If it's the first char equal, startingIndex will be -1, so we should update the starting index
                if(startingIndex == -1) startingIndex = hsPointer;
                needlePointer++;
            }
            // If the chars are not equal and we already have a starting index, restart it and push back the haystack
            // pointer to the starting index + 1
            else if(startingIndex != -1)
            {
                needlePointer = 0;
                hsPointer = startingIndex;
                startingIndex = -1;
            }
            
            hsPointer++;
        }
        
        // If the needle pointer is equal to the needle length, it means the needle has found
        return needlePointer == needle.Length ? startingIndex : -1;
    }
}