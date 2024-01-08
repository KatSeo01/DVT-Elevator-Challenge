//The IElevator interface defines methods: CurrentFloor, and AddPerson
interface IElevator
{
    int CurrentFloor { get; }
    void AddPerson(Person person);
}