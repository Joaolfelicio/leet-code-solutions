public class MinStack {
    private int minValue = Int32.MaxValue;
    private int[] stack = null;
    public int size = 2;
    public int numOfElems = 0;
    
    public MinStack() {
        stack = new int[size];
    }
    
    public void Push(int x) {
        
        if(x < minValue)
        {
            minValue = x;
        }
        
        stack[++numOfElems - 1] = x;
        
        if(numOfElems / size > 0.5)
        {
            resize();
        }
    }
    
    public void Pop() {
        var temp = stack[numOfElems - 1];
        
        numOfElems--;
        
        if(temp == minValue)
        {
            minValue = newMinValue();
        }
    }
    
    public int Top() {
        return stack[numOfElems - 1];
    }
    
    public int GetMin() {
        return minValue;
    }
    
    private void resize()
    {
        size = size * 2;
        
        var newStack = new int[size];
        
        for(int i = 0; i < numOfElems; i++)
        {
            newStack[i] = stack[i];
        }
        
        stack = newStack;
    }
    
    private int newMinValue()
    {
        int minValue = int.MaxValue;
        for(int i = 0; i < numOfElems; i++)
        {
            if(stack[i] < minValue)
            {
                minValue = stack[i];
            }
        }
        return minValue;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */