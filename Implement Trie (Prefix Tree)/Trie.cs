public class Trie 
{
    TrieNode Root {get;}
    /** Initialize your data structure here. */
    public Trie() 
    {
        Root = new TrieNode();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) 
    {
        Insert(word, 0, Root);
    }
    
    private void Insert(string word, int index, TrieNode node)
    {
        var currentChar = word[index];
               
        if(!node.Children.ContainsKey(currentChar))
            node.Children[currentChar] = new TrieNode(currentChar);
        
        if(word.Length - 1 == index) node.Children[currentChar].IsWord = true;
        else Insert(word, index + 1, node.Children[currentChar]);
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) 
    {
        var target = Search(word, 0, Root);
        
        return target != null && target.IsWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) 
    {
        return Search(prefix, 0, Root) != null;
    }
    
    private TrieNode Search(string word, int index, TrieNode node)
    {
        var currentChar = word[index];
        
        if(!node.Children.ContainsKey(currentChar)) return null;
        
        var child = node.Children[currentChar];
        
        if(word.Length - 1 == index) return child;
        else return Search(word, index + 1, child);
    }
}

public class TrieNode
{
    public char Value {get;}
    public Dictionary<char, TrieNode> Children {get; set;}
    public bool IsWord {get; set;}
    
    public TrieNode(char value = '\0')
    {
        Value = value;
        Children = new Dictionary<char, TrieNode>();
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */