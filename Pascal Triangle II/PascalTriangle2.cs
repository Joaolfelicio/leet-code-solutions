public class Solution 
{
    public IList<int> GetRow(int rowIndex) 
    {
        var firstRow = new int[1];
        firstRow[0] = 1;
        
        return ComputeRow(firstRow, 0, rowIndex);
    }
    
    private IList<int> ComputeRow(IList<int> prevRow, int rowIndex, int targetRowIndex)
    {
        if(rowIndex == targetRowIndex + 1) return prevRow;
        
        var row = new int[rowIndex + 1];
        
        // First value and last are always 1
        row[0] = 1;
        row[row.Length - 1] = 1;
                
        for(int i = 1; i < row.Length - 1; i++)
        {
            row[i] = prevRow[i - 1] + prevRow[i];
        }
        
        return ComputeRow(row, ++rowIndex, targetRowIndex);
    }
}