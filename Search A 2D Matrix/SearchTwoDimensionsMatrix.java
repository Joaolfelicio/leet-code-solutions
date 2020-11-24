class Solution {
    public boolean searchMatrix(int[][] matrix, int target) {
        
        if(matrix == null || matrix.length == 0) return false;
        
        int row = 0;
        int column = matrix[0].length - 1;
        
        while(column >= 0 && row < matrix.length) {
            
            if(matrix[row][column] > target) {
                column--;
            }
            else if(matrix[row][column] < target) {
                row++;
            }
            else {
                return true;
            }
        }
        
        return false;
    }
}