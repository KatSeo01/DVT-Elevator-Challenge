//The Elevator class implements the IElevator interface. It has private fields for the number of floors, current floor, direction, and list of people in the elevator. 
class Elevator : IElevator
{
    private int numFloors;
    private int currentFloor;
    private int direction;
    private List<Person> people;

    public Elevator(int numFloors)
    {
        this.numFloors = numFloors;
        this.currentFloor = 1;
        this.direction = 0;
        this.people = new List<Person>();
    }

    public int CurrentFloor
    {
        get { return this.currentFloor; }
    }

    public void AddPerson(Person person)
    {
        this.people.Add(person);
    }

    public void Update()
    {
        // Move the elevator
        this.currentFloor += this.direction;

        // Change direction if necessary
        if (this.currentFloor == 1)
        {
            this.direction = 1;
        }
        else if (this.currentFloor == this.numFloors)
        {
            this.direction = -1;
        }

        // Remove people who have reached their destination
        this.people.RemoveAll(p => p.DestinationFloor == this.currentFloor);
    }
}