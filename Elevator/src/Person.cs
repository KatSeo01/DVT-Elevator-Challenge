//The Person class is responsible for managing a list of people. 
//It has methods to add a person to the list, check if there are people in the list, and remove a person from the list.
class Person
{
    //List of people
    private List<Person> people;

    public Person()
    {
        this.people = new List<Person>();
    }

    //Adding people
    public void AddPerson(int startFloor, int endFloor)
    {
        this.people.Add(new Person(startFloor,endFloor));
    }


    public bool HasPeople()
    {
        return this.people.Count > 0;
    }

    public List<Person> GetPeople()
    {
        return this.people;
    }

    //Removing people from the list
    public void RemovePerson(Person person)
    {
        this.people.Remove(person);
    }
}