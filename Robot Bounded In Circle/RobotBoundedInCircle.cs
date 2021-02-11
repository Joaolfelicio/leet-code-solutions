public class Solution 
{
    public bool IsRobotBounded(string instructions) 
    {
        if(string.IsNullOrWhiteSpace(instructions)) return true;  
        
        // North = 0, East = 1, South = 2, West = 3
        var directions = new int[][]
        {
            new int[] {-1, 0},
            new int[] {0, 1},
            new int[] {1, 0},
            new int[] {0, -1}
        };
        
        // Initial position is (0,0)
        var position = new int[] {0, 0};
        
        var currDict = 0;
        
        foreach(var c in instructions)
        {
            if(c == 'L') currDict = (currDict + 3) % 4;
            else if(c == 'R') currDict = (currDict + 1) % 4;
            else
            {
                position[0] += directions[currDict][0];
                position[1] += directions[currDict][1];
            }
        }
        
        // If after one cycle the robot returns to the
        // initial position, or the robot doesn't face north
        return (position[0] == 0 && position[1] == 0) || currDict != 0;
    }
}