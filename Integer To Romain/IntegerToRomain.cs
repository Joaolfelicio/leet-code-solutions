public class Solution 
{
    public string IntToRoman(int num) 
    {
        if(num <= 0) return string.Empty;
        
        var romanValues = new Roman[]
        {
            new Roman(1000, "M"),
            new Roman(900, "CM"),
            new Roman(500, "D"),
            new Roman(400, "CD"),
            new Roman(100, "C"),
            new Roman(90, "XC"),
            new Roman(50, "L"),
            new Roman(40, "XL"),
            new Roman(10, "X"),
            new Roman(9, "IX"),
            new Roman(5, "V"),
            new Roman(4, "IV"),
            new Roman(1, "I")
        };
        
        var result = new StringBuilder();
        var i = 0;
        
        while(num > 0)
        {               
            if(romanValues[i].Value <= num)
            {
                result.Append(romanValues[i].Symbol);
                num -= romanValues[i].Value;
            }
            else
            {
                i++;
            }
        }
        return result.ToString();
    }
}

public class Roman
{
    public int Value {get; }
    public string Symbol {get; }
    
    public Roman(int value, string symbol)
    {
        Value = value;
        Symbol = symbol;
    }
}