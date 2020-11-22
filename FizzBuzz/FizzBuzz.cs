using System;

public class Solution {
    public IList<string> FizzBuzz(int n) 
    {
        var list = new List<string>();
        int i = 1;
        
        while(i <= n)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                list.Add("FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                list.Add("Fizz");
            }
            else if(i % 5 == 0)
            {
                list.Add("Buzz");
            }
            else
            {
                list.Add(i.ToString());
            }
            
            i++;
        }
        
        return list;
    }
}