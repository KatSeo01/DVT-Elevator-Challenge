
class Person
{
   private int startFloor;
    private int destinationFloor;

    public Person(int startFloor, int destinationFloor)
    {
        this.startFloor = startFloor;
        this.destinationFloor = destinationFloor;
    }

    public int CurrentFloor
    {
        get { return this.startFloor; }
    }

    public int DestinationFloor
    {
        get { return this.destinationFloor; }
    }

    public bool HasReachedDestination()
    {
        return this.startFloor
    }    
}