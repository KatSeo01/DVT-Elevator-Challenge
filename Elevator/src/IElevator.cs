//The IElevator interface defines three methods: CurrentFloor, AddPerson, and Update
interface IElevator
    {
        int CurrentFloor { get; }
        void AddPerson(Person person);
        void Update();
    }