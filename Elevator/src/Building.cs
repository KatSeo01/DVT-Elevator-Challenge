//The Building class represents a building with elevators. It has a list of elevators and a Person object to manage the people waiting for elevators. 
//The Building class has methods to add a person to the Person, check if there are people waiting for elevators, and update the state of the elevators and people.

class Building
{
    private List<Elevator> elevators;
    private Person person;
    private int numFloors;

    public Building(int numFloors, int numElevators)
    {
        this.numFloors = numFloors;
        this.elevators = new List<Elevator>();
        for(int i = 0; i < numElevators; i++)
        {
            this.elevators.Add(new Elevator(numFloors));
        }
        this.person = new Person();
    }

    public void AddPerson(int startFloor, int endFloor)
    {
        this.person.AddPerson(startFloor,endFloor);
    }

    public bool HasPeople()
    {
        return.this.person.HasPeople();
    }

    public void Update()
    {
        //Update each elevator
        foreach(Elevator elevator in this.elevators)
        {
            elevator.Update();
        }

        //Assign people to elevators
        foreach(Person person in this.person.GetPeople())
        {
            Elevator closestElevator = null;
            int closestDistance = int.MaxValue;
            foreach (Elevator elevator in this.elevators)
            {
                int distance = Math.Abs(elevator.CurrentFloor - person.CurrentFloor);
                if (distance < closestDistance)
                {
                    closestElevator = elevator;
                    closestDistance = distance;
                }
            }
            closestElevator.AddPerson(person);
            this.personManager.RemovePerson(person);
        }

    }
}