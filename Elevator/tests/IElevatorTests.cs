using NUnit.Framework;
using System;


public class IElevatorTest
{
[Test]
public void Should_Return_Current_Floor()
{
    // Arrange
    const int currentFloor = 2;
    _elevator.CurrentFloor.Returns(currentFloor);

    // Act
    var result = _elevator.CurrentFloor;

    // Assert
    Assert.AreEqual(currentFloor, result);
}

[Test]
public void Should_Add_Person_To_Elevator()
{
    // Arrange
    var person = _people[0];

    // Act
    _elevator.AddPerson(person);

    // Assert
    _elevator.Received().AddPerson(person);
}

}
