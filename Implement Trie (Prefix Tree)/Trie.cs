public class Trie 
{
    private TrieNode Root {get; set;}
    
    /** Initialize your data structure here. */
    public Trie() 
    {
        Root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) 
    {
        var current = Root;
        
        for(int i = 0; i < word.Length; i++)
        {
            var c = word[i];
            var charIndex = c - 'a';

            if(current.Children[charIndex] == null) 
                current.Children[charIndex] = new TrieNode(c);
            
            current = current.Children[charIndex];
        }
        current.IsWord = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) 
    {
        var node = Find(word);
        
        return node != null && node.IsWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) 
    {
        return Find(prefix) != null;
    }
    
    private TrieNode Find(string searchTerm)
    {
        var current = Root;
        
        for(int i = 0; i < searchTerm.Length; i++)
        {
            var c = searchTerm[i];
            
            var childNode = current.Children[c - 'a'];
            
            if(childNode == null) return null;
            else current = childNode;
        }
        
        return current;
    }
}

public class TrieNode
{
    public char Character {get;}
    public bool IsWord {get; set;}
    public TrieNode[] Children {get;}
    
    public TrieNode(char character = '\0', bool isWord = false)
    {
        Character = character;
        IsWord = isWord;
        Children = new TrieNode[26];
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */