public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        if(numbers == null || numbers.Length < 2) return new int[0];
        
        var start = 0;
        var end = numbers.Length - 1;
        
        while(start < end)
        {
            var sum = numbers[start] + numbers[end];
            
            if(sum == target) return new int[] {start + 1, end + 1};
            else if(sum > target) end--;
            else start++;
                
        }
        return new int[0];
    }
}