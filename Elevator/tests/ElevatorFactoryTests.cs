using NUnit.Framework;
using System;

namespace Elevator.Tests
{
    public class Tests
    {
        [Test]
        public void CreateElevator_NegativeFloors_ThrowsArgumentException()
        {
            // Arrange
            IElevatorFactory factory = new ElevatorFactory();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => factory.CreateElevator(-1));
        }

        [Test]
        public void CreateElevator_ZeroFloors_ThrowsArgumentException()
        {
            // Arrange
            IElevatorFactory factory = new ElevatorFactory();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => factory.CreateElevator(0));
        }

        [Test]
        public void CreateElevator_PositiveFloors_ReturnsNewElevatorInstance()
        {
            // Arrange
            IElevatorFactory factory = new ElevatorFactory();

            // Act
            IElevator elevator = factory.CreateElevator(1);

            // Assert
            Assert.IsNotNull(elevator);
            Assert.AreEqual(1, elevator.NumFloors);
        }
    }
}