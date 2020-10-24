using System;

int Reverse(int x) {
    var xStr = x.ToString();
    
    if(x < 0) {
        xStr = xStr.Substring(1);
    }
    
    var xCharArr = xStr.ToCharArray();
    
    Array.Reverse(xCharArr);
    
    var resultStr = new string(xCharArr);
                    
    if(x < 0) {
        resultStr = resultStr.Insert(0, "-");
    }
    
    try {
        return Convert.ToInt32(resultStr);
    } catch(Exception ex) {
        return 0;
    }
    
}

