//The IElevator interface defines methods
interface IElevator : IElevatorMovement
{
    int CurrentFloor { get; }
    Direction CurrentDirection { get; }
    ElevatorState State { get; }
    List<Person> Passengers { get; }
    int PassengerLimit { get; set; }
    void AddPerson(Person person);
    void Update();
}