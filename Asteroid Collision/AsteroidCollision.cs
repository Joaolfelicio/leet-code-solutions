public class Solution 
{
    public int[] AsteroidCollision(int[] asteroids) 
    {
        if(asteroids == null || asteroids.Length == 0) return new int[0];
        
        var stack = new Stack<int>();
        stack.Push(asteroids[0]);
                
        for(int i = 1; i < asteroids.Length; i++)
        {
            if(stack.Count == 0 || HaveSameDirection(stack.Peek(), asteroids[i]) || stack.Peek() < 0 && asteroids[i] > 0) 
            {
                stack.Push(asteroids[i]);
                continue;
            }
            else
            {
                AsteroidsCollision(stack, asteroids[i]);
            }
        }
        
        var result = new int[stack.Count];
        
        for(int i = result.Length - 1; i >= 0; i--) result[i] = stack.Pop();
        
        return result;
    }
    
    private void AsteroidsCollision(Stack<int> stack, int current)
    {             
        while(stack.Count > 0)
        {
            if(HaveSameDirection(stack.Peek(), current)) break;
            
            if(Math.Abs(stack.Peek()) > Math.Abs(current))
            {
                return;
            }
            else if(Math.Abs(stack.Peek()) < Math.Abs(current))
            {
                stack.Pop();
            }
            else
            {
                stack.Pop();
                return;
            }
        }
        
        stack.Push(current);
        
    }

    private bool HaveSameDirection(int stackAster, int incomingAster) => (stackAster > 0 && incomingAster > 0) || (stackAster < 0 && incomingAster < 0);
}