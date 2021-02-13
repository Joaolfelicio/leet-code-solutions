public class Solution 
{
    public int NumEquivDominoPairs(int[][] dominoes) 
    {
        var sum = 0;
        
        var sequence = new Dictionary<string, int>();
        
        foreach(var domino in dominoes)
        {
            var seq1 = $"{domino[0]},{domino[1]}";
            var seq2 = $"{domino[1]},{domino[0]}";
                
            if(sequence.ContainsKey(seq1))
            {
                sequence[seq1] = sequence[seq1] + 1;
            }
            else if(sequence.ContainsKey(seq2))
            {
                sequence[seq2] = sequence[seq2] + 1;             
            }
            else
            {
                sequence.Add(seq1, 1);
            }
        }
        
        foreach(var key in sequence.Keys)
        {
            // Formula to count pairs = N(N - 1) / 2
            sum += sequence[key] * (sequence[key] - 1) / 2;
        }
        
        return sum;
    }
}