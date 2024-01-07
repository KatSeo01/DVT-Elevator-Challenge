using System;
using System.Threading.Tasks;

namespace ElevatorChallenge
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create a building with 10 floors and 2 elevators
            Building building = new Building(10, new ElevatorFactory());

            // Add some people to the building
            building.AddPerson(1, 5, 1);
            building.AddPerson(2, 3, 2);
            building.AddPerson(3, 7, 3);
            building.AddPerson(4, 2, 1);
            building.AddPerson(5, 8, 2);

            // Run the simulation
            await building.RequestElevatorAsync(1, 9, 1);

            while (building.HasPeople())
            {
                building.Update();
                await Task.Delay(500); // Introduce delay for better visualization
            }
        }
    }
}
