using System;

void ReverseString(char[] s) 
{
    ExchangePosition(s, 0, s.Length - 1);
}

void ExchangePosition(char[] s, int p1, int p2) 
{
    if(p1 < p2)
    {
        char temp = s[p1];
        s[p1] = s[p2];
        s[p2] = temp;
        
        ExchangePosition(s, ++p1, --p2);
    }
}
