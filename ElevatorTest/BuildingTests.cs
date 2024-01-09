using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
namespace ElevatorTest
{
    public class BuildingTests
    {
        [Test]
        public void TestAddPerson()
        {
            // Test normal case
            var building = new Building(10, new ElevatorFactory());
            building.AddPerson(1, 10, 2);
            Assert.AreEqual(1, building.personManager.GetPeople().Count);

            // Test with zero passengers
            Assert.Throws<ArgumentOutOfRangeException>(() => building.AddPerson(1, 10, 0));

            // Test with negative passengers
            Assert.Throws<ArgumentOutOfRangeException>(() => building.AddPerson(1, 10, -1));
        }

        [Test]
        public void TestHasPeople()
        {
            // Test normal case
            var building = new Building(10, new ElevatorFactory());
            building.AddPerson(1, 10, 2);
            Assert.IsTrue(building.HasPeople());

            // Test with no people
            var building2 = new Building(10, new ElevatorFactory());
            Assert.IsFalse(building2.HasPeople());
        }

        [Test]
        public async Task TestRequestElevatorAsync()
        {
            // Test normal case
            var building = new Building(10, new ElevatorFactory());
            building.AddPerson(1, 10, 2);
            await building.RequestElevatorAsync(1, 10, 2);
            Assert.IsFalse(building.HasPeople());

            // Test with zero passengers
            Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await building.RequestElevatorAsync(1, 10, 0));

            // Test with negative passengers
            Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await building.RequestElevatorAsync(1, 10, -1));
        }

        [Test]
        public void TestUpdate()
        {
            // Test normal case
            var building = new Building(10, new ElevatorFactory());
            building.AddPerson(1, 10, 2);
            building.Update();
            Assert.IsFalse(building.HasPeople());

            // Test with no people
            var building2 = new Building(10, new ElevatorFactory());
            building2.Update();
            Assert.IsFalse(building2.HasPeople());
        }

        [Test]
        public void TestFindNearestElevator()
        {
            // Test normal case
            var building = new Building(10, new ElevatorFactory());
            building.elevators[0].CurrentFloor = 5;
            building.elevators[1].CurrentFloor = 1;
            Assert.AreEqual(building.elevators[1], building.FindNearestElevator(1));

            // Test with multiple nearest elevators
            building.elevators[0].CurrentFloor = 1;
            Assert.IsTrue(new List<IElevator> { building.elevators[0], building.elevators[1] }.Contains(building.FindNearestElevator(1)));
        }

        [Test]
        public void TestValidateFloor()
        {
            // Test normal case
            var building = new Building(10, new ElevatorFactory());
            Assert.DoesNotThrow(() => building.ValidateFloor(1, "floor"));

            // Test with floor less than 1
            Assert.Throws<ArgumentOutOfRangeException>(() => building.ValidateFloor(0, "floor"));

            // Test with floor greater than the total number of floors
            Assert.Throws<ArgumentOutOfRangeException>(() => building.ValidateFloor(11, "floor"));
        }
    }
}