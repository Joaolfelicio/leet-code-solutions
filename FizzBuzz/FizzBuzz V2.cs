using System;

public class Solution {
    public IList<string> FizzBuzz(int n) 
    {
        var list = new List<string>();
        int i = 1;
        
        while(i <= n)
        {
            string result = "";
            
            if(i % 3 == 0)
            {
                result += "Fizz";
            }
            
            if(i % 5 == 0)
            {
                result += "Buzz";
            }
            
            if(i % 3 != 0 && i % 5 != 0)
            {
                result = i.ToString();
            }
            
            list.Add(result);
            i++;
        }
        
        return list;
    }
}