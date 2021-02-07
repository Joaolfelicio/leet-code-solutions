public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        var result = new int[2];
        
        if(numbers == null || numbers.Length == 0) return result;
        
        var left = 0;
        var right = numbers.Length - 1;
        
        while(left < right)
        {
            var sum = numbers[left] + numbers[right];
            
            if(sum < target) left++;
            else if(sum > target) right--;
            else return new int[] {left + 1, right + 1};
        }
        return result;
    }
}