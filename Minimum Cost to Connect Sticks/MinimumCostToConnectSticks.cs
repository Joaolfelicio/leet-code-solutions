public class Solution 
{
    public int ConnectSticks(int[] sticks) 
    {
        if (sticks == null || sticks.Length <= 1)
        {
            return 0;
        }
        
        Array.Sort(sticks);
        
        var orderedSticks = new Queue<int>(sticks);
        var joinedSticks = new Queue<int>();
        
        var totalCost = 0;
        while (orderedSticks.Count + joinedSticks.Count > 1)
        {
            var first = GetMinStick(orderedSticks, joinedSticks);
            var second = GetMinStick(orderedSticks, joinedSticks);
            var cost = first + second;
            
            totalCost += cost;
            joinedSticks.Enqueue(cost);
        }
        
        return totalCost;
    }
    
    private static int GetMinStick(Queue<int> orderedSticks, Queue<int> joinedSticks)
    {
        if (orderedSticks.Count == 0)
        {
            return joinedSticks.Dequeue();
        }
        
        if (joinedSticks.Count == 0)
        {
            return orderedSticks.Dequeue();
        }
        
        if (joinedSticks.Peek() < orderedSticks.Peek())
        {
            return joinedSticks.Dequeue();
        }
        else
        {
            return orderedSticks.Dequeue();
        }
    }
}