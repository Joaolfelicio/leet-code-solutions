public class Solution 
{
    public IList<string> FindWords(char[][] board, string[] words) 
    {
        var result = new List<string>();
        
        if(board == null || board.Length == 0 || board[0].Length == 0 || words == null || words.Length == 0)
            return result;
        
        var wordDict = GetWordDict(words);
        
        for(int row = 0; row < board.Length; row++)
        {
            for(int col = 0; col < board[row].Length; col++)
            {
                var firstChar = board[row][col];
                
                if(!wordDict.ContainsKey(firstChar)) continue;
                
                var targetWords = wordDict[firstChar];
                var wordsToRemove = new List<string>();
                
                foreach(var word in targetWords)
                {
                    if(Backtrack(board, word, 0, row, col, new HashSet<string>())) 
                    {
                        result.Add(word);
                        wordsToRemove.Add(word);
                    }
                }
                
                foreach(var wordToRemove in wordsToRemove)
                {
                    if(targetWords.Count > 1) targetWords.Remove(wordToRemove);
                    else wordDict.Remove(firstChar);
                }

                if(wordDict.Count == 0) return result;
            }
        }
        
        return result;
    }
    
    private bool Backtrack(char[][] board, string word, int index, int row, int col, HashSet<string> visited)
    {
        if(index == word.Length - 1) return true;
        
        visited.Add($"{row},{col}");
        
        foreach(var neighbour in GetNeighbours(board, word[index + 1], row, col, visited))
        {
            if(Backtrack(board, word, index + 1, neighbour[0], neighbour[1], visited)) return true;
        }
        
        visited.Remove($"{row},{col}");
        
        return false;
    }
    
    private List<int[]> GetNeighbours(char[][] board, char target, int row, int col, HashSet<string> visited)
    {
        var result = new List<int[]>();
        
        var directions = new int[][]
        {
            new int[] {0, 1},
            new int[] {1, 0},
            new int[] {0, -1},
            new int[] {-1, 0}
        };
        
        foreach(var dir in directions)
        {
            var newRow = row + dir[0];
            var newCol = col + dir[1];
            
            if(newRow < 0 || newRow >= board.Length ||
               newCol < 0 || newCol >= board[newRow].Length ||
               board[newRow][newCol] != target || visited.Contains($"{newRow},{newCol}")) continue;
            
            result.Add(new int[] {newRow, newCol});
        }
        return result;
    }
    
    private Dictionary<char, List<string>> GetWordDict(string[] words)
    {
        var result = new Dictionary<char, List<string>>();
        
        foreach(var word in words)
        {
            var firstChar = word[0];
            
            if(result.ContainsKey(firstChar)) result[firstChar].Add(word);
            else result[firstChar] = new List<string>() {word};
        }
        return result;
    }
}