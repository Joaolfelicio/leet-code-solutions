public class FirstUnique 
{
    public Queue<int> Numbers {get; }
    public Dictionary<int, DoubleLinkedList> Dict {get; }
    public DoubleLinkedList Head {get; set;}
    public DoubleLinkedList Tail {get; set;}

    public FirstUnique(int[] nums) 
    {
        Numbers = new Queue<int>();
        Dict = new Dictionary<int, DoubleLinkedList>();
        
        foreach(var num in nums)
        {
            Add(num);
        }
    }
    
    public int ShowFirstUnique() 
    {
        if(Head != null) return Head.Val;
        
        return -1;
    }
    
    public void Add(int value) 
    {
        if(Dict.ContainsKey(value))
        {
            Numbers.Enqueue(value);
            RemoveNonUnique(value);
            return;
        }
               
        var newNode = new DoubleLinkedList(null, value); 
        
        if(Head == null)
        {           
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Prev = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }
        
        Dict.Add(value, newNode); 
        Numbers.Enqueue(value);
    }

    
    private void RemoveNonUnique(int num) 
    {
        var node = Dict[num];
        
        if(node == null) return;
        
        var prev = node.Prev; 
        var next = node.Next; 
        
        if(Head == node) Head = Head.Next;
        if(prev != null) prev.Next = next;
        if(next != null) next.Prev = prev;
        
        Dict[num] = null;
    }
}

public class DoubleLinkedList
{
    public DoubleLinkedList Next {get; set;}
    public DoubleLinkedList Prev {get; set;}
    public int Val {get; set;}
    
    public DoubleLinkedList(DoubleLinkedList prev, int val)
    {
        Prev = prev;
        Val = val;
    }
}

/**
 * Your FirstUnique object will be instantiated and called as such:
 * FirstUnique obj = new FirstUnique(nums);
 * int param_1 = obj.ShowFirstUnique();
 * obj.Add(value);
 */