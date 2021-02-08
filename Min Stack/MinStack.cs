public class MinStack 
{
    private Node Head {get; set;}
    /** initialize your data structure here. */
    public MinStack() 
    {
       Head = null; 
    }
    
    public void Push(int x) 
    {
        if(Head == null)
        {
            Head = new Node(x, x);
        }
        else 
        {
            var newNode = new Node(x, Math.Min(x, Head.Min), Head);
            Head = newNode;
        }
    }
    
    public void Pop() 
    {
        Head = Head.Next;
    }
    
    public int Top() 
    {
        return Head.Value;
    }
    
    public int GetMin() 
    {
        return Head.Min;
    }
}

public class Node
{
    public int Value {get;}
    public int Min {get;}
    public Node Next {get; set;}
    
    public Node(int value, int min, Node next)
    {
        Value = value;
        Min = min;
        Next = next;
    }
    
    public Node(int value, int min) : this(value, min, null) {}
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */