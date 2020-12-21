public class Solution {
    public int Fib(int n) 
    {       
        return CalculateFib(n, new Dictionary<int, int>());
    }
    
    private int CalculateFib(int n, Dictionary<int, int> dict)
    {   
        if (n < 2) return n;        
        if (dict.ContainsKey(n)) return dict[n];
                
        var result = CalculateFib(n - 1, dict) + CalculateFib(n - 2, dict);
        
        dict.Add(n, result);
        return result;
    }
}