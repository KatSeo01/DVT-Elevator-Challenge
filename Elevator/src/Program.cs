using System;
using System.Collections.Generic;

namespace ElevatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a building with 10 floors and 2 elevators
            Building building = new Building(10, new ElevatorFactory());

            // Add some people to the building
            building.AddPerson(1, 5);
            building.AddPerson(2, 3);
            building.AddPerson(3, 7);
            building.AddPerson(4, 2);
            building.AddPerson(5, 8);

            // Run the simulation
            while (building.HasPeople())
            {
                building.Update();
            }
        }
    }
}