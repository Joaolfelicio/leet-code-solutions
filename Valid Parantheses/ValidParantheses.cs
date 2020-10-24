using System;

bool IsValid(string s) 
{
    Hashtable values = new Hashtable() 
    {
        {'(', ')'},
        {'{', '}'},
        {'[', ']'}
    };
    
    Stack symbolStack = new Stack();

    foreach(char current in s) 
    {
        if(values.ContainsKey(current)) 
        {
            symbolStack.Push(values[current]);  
        }
        else 
        {
            if(symbolStack.Count > 0 && current == (char) symbolStack.Peek()) 
            {
                symbolStack.Pop();
            }
            else
            {
                return false;
            }
        }
    }
    return symbolStack.Count == 0;
}
