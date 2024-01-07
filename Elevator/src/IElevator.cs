interface IElevator
{
    int CurrentFloor {get; }
    void AddPerson(Person person);
    void Update();
}