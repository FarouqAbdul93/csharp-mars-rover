using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Console.InputLayer;
using MarsRover.Console.LogicLayer;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class RoverTests
    {

        //Turn Right tests

        [Test]
        public void TurnRight_From_North_Faces_East()
        {
            // Arrange
            Position startPosition = new Position(0, 0, CompassDirection.N);
            Rover rover = new Rover(startPosition);
            // Act
            rover.TurnRight();
            // Assert
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(CompassDirection.E));
        }

        [Test]
        public void TurnRight_From_East_Faces_South()
        {
            // Arrange
            Position startPosition = new Position(0, 0, CompassDirection.E);
            Rover rover = new Rover(startPosition);
            // Act
            rover.TurnRight();
            // Assert
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(CompassDirection.S));
        }

        [Test]
        public void TurnRight_From_South_Faces_West()
        {
            // Arrange
            Position startPosition = new Position(0, 0, CompassDirection.S);
            Rover rover = new Rover(startPosition);
            // Act
            rover.TurnRight();
            // Assert
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(CompassDirection.W));
        }

        [Test]
        public void TurnRight_From_West_Faces_North()
        {
            // Arrange
            Position startPosition = new Position(0, 0, CompassDirection.W);
            Rover rover = new Rover(startPosition);
            // Act
            rover.TurnRight();
            // Assert
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(CompassDirection.N));
        }


        //Turn Left tests

        [Test]
        public void TurnLeft_From_North_Faces_West()
        {
            // Arrange
            Position startPosition = new Position(0, 0, CompassDirection.N);
            Rover rover = new Rover(startPosition);
            // Act
            rover.TurnLeft();
            // Assert
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(CompassDirection.W));
        }

        [Test]
        public void TurnLeft_From_West_Faces_South()
        {
            // Arrange
            Position startPosition = new Position(0, 0, CompassDirection.W);
            Rover rover = new Rover(startPosition);
            // Act
            rover.TurnLeft();
            // Assert
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(CompassDirection.S));
        }

        [Test]
        public void TurnLeft_From_South_Faces_East()
        {
            // Arrange
            Position startPosition = new Position(0, 0, CompassDirection.S);
            Rover rover = new Rover(startPosition);
            // Act
            rover.TurnLeft();
            // Assert
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(CompassDirection.E));
        }

        [Test]
        public void TurnLeft_From_East_Faces_North()
        {
            // Arrange
            Position startPosition = new Position(0, 0, CompassDirection.E);
            Rover rover = new Rover(startPosition);
            // Act
            rover.TurnLeft();
            // Assert
            Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(CompassDirection.N));
        }
    }
}
