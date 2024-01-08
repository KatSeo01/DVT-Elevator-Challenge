interface IElevatorRequestHandler
{
    Task RequestElevatorAsync(int fromFloor, int toFloor, int numPassengers);
}