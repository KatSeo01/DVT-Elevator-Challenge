class ElevatorFactory :IElevatorFactory
{
    public IElevator CreateElevator(int numFloors)
    {
        return new Elevator(numFloors);
    }
} 

