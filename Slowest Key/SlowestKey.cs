public class Solution 
{
    public char SlowestKey(int[] releaseTimes, string keysPressed) 
    {
        if(releaseTimes == null || releaseTimes.Length == 0 || string.IsNullOrWhiteSpace(keysPressed)) return '\0';
        
        char longestKey = keysPressed[0];
        int maxSeconds = releaseTimes[0];
        
        for(int i = 1; i < keysPressed.Length; i++)
        {
            var seconds = releaseTimes[i] - releaseTimes[i - 1];
            
            if(seconds > maxSeconds || (seconds == maxSeconds && keysPressed[i] > longestKey))
            {
                longestKey = keysPressed[i];
                maxSeconds = seconds;
            }
        }
        return longestKey;
    }
}