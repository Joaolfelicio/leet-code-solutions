public class Solution 
{
    public string NumberToWords(int num) 
    {   
        if(num < 0) return "";
        if(num == 0) return "Zero";
        
        var numbersLess20 = GetNumbersLess20();
        var numbersTens = GetNumbersTens();
        var thousands = GetThousands();
        
        var result = new StringBuilder();
        int i = 0;

        while(num > 0)
        {
            var divided = num % 1000;
            
            if(divided % 1000 != 0) 
                result.Insert(0, $"{Helper(divided, numbersTens, numbersLess20)}{thousands[i]} ");
            
            num /= 1000;
            i++;
        }
        return result.ToString().TrimEnd();
    }
    
    private string Helper(int num, string[] numbersTens, string[] numbersLess20)
    {
        if(num == 0) return 
            string.Empty;
        else if(num < 20) 
            return $"{numbersLess20[num]} ";
        else if(num < 100) 
            return $"{numbersTens[num / 10]} {Helper(num % 10, numbersTens, numbersLess20)}";
        else 
            return $"{numbersLess20[num / 100]} Hundred {Helper(num % 100, numbersTens, numbersLess20)}";
    }
    
    private string[] GetNumbersLess20()
    {
        return new string[]{"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    }
    
    private string[] GetNumbersTens()
    {
        return new string[] {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
    }
    
    private string[] GetThousands()
    {
        return new string[] {"", "Thousand", "Million", "Billion"};
    }
}