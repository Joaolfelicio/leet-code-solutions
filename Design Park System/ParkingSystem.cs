public class ParkingSystem 
{
    int numOfBig = 0;
    int numOfMedium = 0;
    int numOfSmall = 0;
    
    public ParkingSystem(int big, int medium, int small) 
    {
        numOfBig = big;
        numOfMedium = medium;
        numOfSmall = small;
    }
    
    public bool AddCar(int carType) 
    {
        if(carType == 1 && numOfBig > 0)
        {
            numOfBig--;
            return true;
        }
        else if(carType == 2 && numOfMedium > 0)
        {
            numOfMedium--;
            return true;
        }
        else if(carType == 3 && numOfSmall > 0)
        {
            numOfSmall--;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */