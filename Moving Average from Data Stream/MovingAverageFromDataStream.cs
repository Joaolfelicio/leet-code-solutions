public class MovingAverage 
{
    private int Size {get;}
    private int Sum {get; set;}
    private Queue<int> Elems {get;}
    
    /** Initialize your data structure here. */
    public MovingAverage(int size) 
    {
        Size = size;
        Sum = 0;
        Elems = new Queue<int>();
    }
    
    public double Next(int val) 
    {
        Elems.Enqueue(val);
        Sum += val;
        
        if(Elems.Count > Size)
        {
            Sum -= Elems.Dequeue();
        }
        
        return (double) Sum / (double) Elems.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */