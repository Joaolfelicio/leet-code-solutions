using System;

int[] PlusOne(int[] digits) 
{
    int rest = 0;
    
    digits[digits.Length - 1]++;
    
    if(digits[digits.Length - 1] == 10)
    {
        digits[digits.Length - 1] = 0;
        rest++;
    }
    
    for(int i = digits.Length - 2; i >= 0; i--)
    {

        if(rest > 0)
        {
            digits[i] = digits[i] + rest;
            rest--;
            
            if(digits[i] == 10)
            {
                digits[i] = 0;
                rest++;
            }
        }
    }
    
    if(rest > 0)
    {
        int[] temp = new int[digits.Length + 1];
        temp[0] = 1;

        for(int k = 0; k < digits.Length; k++)
        {
            temp[k+1] = digits[k];
        }
        digits = temp;
    }
    
    return digits;
}