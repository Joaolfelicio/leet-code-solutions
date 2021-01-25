public class FileSystem 
{
    public Directory Root {get;set;}

    public FileSystem() 
    {
        Root = new Directory("", "/");
    }
    
    public IList<string> Ls(string path)
    {
        var arrEntries = path.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
        
        return GetEntry(arrEntries, Root).GetEntries();
    }
    
    public void Mkdir(string path) 
    {
        var arrDir = path.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
        
        GetEntry(arrDir, Root);
    }
    
    public void AddContentToFile(string filePath, string content) 
    {
        var arrEntry = filePath.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
        
        GetFile(arrEntry, Root).AddContent(content);
    }
    
    public string ReadContentFromFile(string filePath)
    {
        var arrEntry = filePath.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
        
        return GetFile(arrEntry, Root).Content;
    }
    
    private File GetFile(string[] path, Entry entry)
    {
        if(path.Length == 0) return (File) entry;
        
        var name = path[0];
        var dir = (Directory) entry;
        
        if(!dir.Entries.ContainsKey(name)) dir.Entries.Add(name, new File(name, $"{entry.FullPath}/{name}"));
        
        return GetFile(path.Skip(1).ToArray(), dir.Entries[name]);
    }
    
    private Entry GetEntry(string[] path, Entry entry)
    {
        if(path.Length == 0) return entry;
        
        var name = path[0];
        var dir = (Directory) entry;
        
        if(!dir.Entries.ContainsKey(name)) dir.CreateEntry(new Directory(name, $"{dir.FullPath}/{name}"));
        
        return GetEntry(path.Skip(1).ToArray(), dir.Entries[name]);
    }
}

public abstract class Entry
{
    public Entry(string name, string fullPath)
    {
        Name = name;
        FullPath = fullPath;
    }
    
    public string FullPath {get; set;}
    public string Name {get; set;}
    
    public abstract IList<string> GetEntries();
}

public class File : Entry
{
    public File(string name, string fullPath) : base(name, fullPath) 
    {
        Content = string.Empty;
    }
    
    public string Content {get; set;}
    
    public void AddContent(string content) => Content += content;
    
    public override IList<string> GetEntries() => new List<string>() {Name};
}

public class Directory : Entry
{
    public Directory(string name, string fullPath) : base(name, fullPath) 
    {
        Entries = new SortedDictionary<string, Entry>();
    }
    
    public Entry CreateEntry(Entry entry) 
    {
        entry.FullPath = $"{FullPath}/{entry.Name}";
        Entries.Add(entry.Name, entry);
        return entry;
    }
    public SortedDictionary<string, Entry> Entries {get;set;}
    public override IList<string> GetEntries() => new List<string>(Entries.Keys);
}

/**
 * Your FileSystem object will be instantiated and called as such:
 * FileSystem obj = new FileSystem();
 * IList<string> param_1 = obj.Ls(path);
 * obj.Mkdir(path);
 * obj.AddContentToFile(filePath,content);
 * string param_4 = obj.ReadContentFromFile(filePath);
 */