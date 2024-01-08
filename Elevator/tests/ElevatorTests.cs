using NUnit.Framework;
using System;

[TestClass]
public class ElevatorTest
{
    [TestMethod]
    public async Task MoveToFloorAsync_SameFloor()
    {
        // Arrange
        int numFloors = 5;
        var elevator = new Elevator(numFloors);

        // Act
        await elevator.MoveToFloorAsync(1);

        // Assert
        Assert.AreEqual(1, elevator.CurrentFloor);
    }

    [TestMethod]
    public async Task MoveToFloorAsync_MovingUp()
    {
        // Arrange
        int numFloors = 5;
        var elevator = new Elevator(numFloors);

        // Act
        await elevator.MoveToFloorAsync(3);

        // Assert
        Assert.AreEqual(3, elevator.CurrentFloor);
    }

    [TestMethod]
    public async Task MoveToFloorAsync_MovingDown()
    {
        // Arrange
        int numFloors = 5;
        var elevator = new Elevator(numFloors);
        elevator.currentFloor = 5;
        elevator.direction = -1;

        // Act
        await elevator.MoveToFloorAsync(3);

        // Assert
        Assert.AreEqual(3, elevator.CurrentFloor);
    }

    [TestMethod]
    public async Task MoveToFloorAsync_RemovesPassengers()
    {
        // Arrange
        int numFloors = 5;
        var elevator = new Elevator(numFloors);
        var person = new Person(2);
        elevator.AddPerson(person);

        // Act
        await elevator.MoveToFloorAsync(2);

        // Assert
        Assert.IsFalse(elevator.people.Contains(person));
    }
}

