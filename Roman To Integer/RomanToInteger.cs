using System;

int RomanToInt(string s) {
    var romanValues = new Hashtable()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };
    
    var sum = 0;
    for(int i = 0; i < s.Length; i++) {
        if(i == s.Length - 1 || (int) romanValues[s[i]] >= (int) romanValues[s[i + 1]]) {
            sum += (int) romanValues[s[i]];
        } else {
            sum -= (int) romanValues[s[i]];
        }
    }
    
    return sum;
}
