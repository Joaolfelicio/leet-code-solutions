using System;

int LengthOfLastWord(string s) {
        
    if(String.IsNullOrWhiteSpace(s))
    {
        return 0;
    }
    
    s = s.Trim(' ');
    
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    var str = new string( charArray );
    
    var firstSpace = str.IndexOf(" ");
    
    return firstSpace == -1 ? s.Length : firstSpace;
}