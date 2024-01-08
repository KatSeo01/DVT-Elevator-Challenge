interface IPassenger
{
    int CurrentFloor { get; }
    int DestinationFloor { get; }
    bool HasReachedDestination();
}
