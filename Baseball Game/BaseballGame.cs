public class Solution 
{
    public int CalPoints(string[] ops) 
    {
        if(ops == null || ops.Length == 0) return -1;
        
        var result = new int[ops.Length];
        var resultIndex = 0;
        
        for(int i = 0; i < ops.Length; i++)
        {
            if(ops[i] == "+")
            {
                result[resultIndex] = result[resultIndex - 1] + result[resultIndex - 2];
            }
            else if(ops[i] == "D")
            {
                result[resultIndex] = result[resultIndex - 1] * 2;
            }
            else if(ops[i] == "C")
            {
                result[--resultIndex] = 0;
            }
            else
            {
                if(!Int32.TryParse(ops[i], out int value)) continue;
                result[resultIndex] = value;
            }
            
            if(ops[i] != "C") resultIndex++;
        }
        
        return result.Sum();
    }
}