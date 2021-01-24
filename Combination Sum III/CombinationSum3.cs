public class Solution 
{
    public IList<IList<int>> CombinationSum3(int k, int n) 
    {
        if(k == 0 || n == 0) return null;
        
        var result = new List<IList<int>>();
        
        Backtracking(result, new LinkedList<int>(), 1, k, n);
        
        return result;
    }
    
    private void Backtracking(List<IList<int>> result, LinkedList<int> output, int index, int count, int remainder)
    {
        if(count == 0 && remainder == 0)
        {
            result.Add(new List<int>(output));
            return;
        }
        else if(count < 0 || remainder < 0) return;
        
        
        for(int i = index; i < 10; i++)
        {
            output.AddLast(i);
            Backtracking(result, output, i + 1, count - 1, remainder - i);
            output.RemoveLast();
        }
    }
}