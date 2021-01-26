public class Solution 
{
    public int MyAtoi(string s) 
    {
        int i = 0;
        int sign = 1;
        int result = 0;
        if (string.IsNullOrWhiteSpace(s)) return 0;

        //Discard whitespaces in the beginning
        while (i < s.Length && s[i] == ' ')
            i++;

        // Check if optional sign if it exists
        if (i < s.Length && (s[i] == '+' || s[i] == '-'))
            sign = s[i++] == '-' ? -1 : 1;

        // Build the result and check for overflow/underflow condition
        while (i < s.Length && s[i] >= '0' && s[i] <= '9') {
            if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && s[i] - '0' > Int32.MaxValue % 10)) {
                return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
            }
            result = result * 10 + (s[i++] - '0');
        }
        return result * sign;
    }
}