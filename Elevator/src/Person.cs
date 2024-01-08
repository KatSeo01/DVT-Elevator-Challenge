//The class tracks the person's starting and destination floors.
class Person : IPassenger
{
   private int startFloor;
    private int destinationFloor;

    public Person(int startFloor, int destinationFloor)
    {
        this.startFloor = startFloor; //The person's starting floor
        this.destinationFloor = destinationFloor; //The person's destination floor
    }

    public int CurrentFloor => this.startFloor;

    public int DestinationFloor => this.destinationFloor;

    // Checks if the person has reached their destination.
    public bool HasReachedDestination()
    {
        return this.startFloor == this.destinationFloor;
    }    
}