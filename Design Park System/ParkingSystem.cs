public class ParkingSystem 
{
    public int BigSpaces {get; set;}
    public int MediumSpaces {get; set;}
    public int SmallSpaces {get; set;}

    public ParkingSystem(int big, int medium, int small) 
    {
        BigSpaces = big;
        MediumSpaces = medium;
        SmallSpaces = small;
    }
    
    public bool AddCar(int carType) 
    {
        return ReduceSpace(carType);
    }
    
    private bool ReduceSpace(int carType)
    {
        if(carType == 1 && BigSpaces > 0) BigSpaces--;
        else if(carType == 2 && MediumSpaces > 0) MediumSpaces--;
        else if(carType == 3 && SmallSpaces > 0) SmallSpaces--;
        else return false;
        
        return true;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */