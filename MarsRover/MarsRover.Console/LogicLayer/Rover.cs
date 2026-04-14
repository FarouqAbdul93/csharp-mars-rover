using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Console.InputLayer;

namespace MarsRover.Console.LogicLayer
{
    public class Rover
    {
        public Position CurrentPosition { get; set; }

        public Rover(Position startPosition)
        {
            CurrentPosition = startPosition;
        }

        public void TurnLeft()
        {
            if (CurrentPosition.Direction == CompassDirection.N)
                CurrentPosition.Direction = CompassDirection.W;
            else if (CurrentPosition.Direction == CompassDirection.W)
                CurrentPosition.Direction = CompassDirection.S;
            else if (CurrentPosition.Direction == CompassDirection.S)
                CurrentPosition.Direction = CompassDirection.E;
            else if (CurrentPosition.Direction == CompassDirection.E)
                CurrentPosition.Direction = CompassDirection.N;
        }

        public void TurnRight()
        {
            if (CurrentPosition.Direction == CompassDirection.N)
                CurrentPosition.Direction = CompassDirection.E;
            else if (CurrentPosition.Direction == CompassDirection.E)
                CurrentPosition.Direction = CompassDirection.S;
            else if (CurrentPosition.Direction == CompassDirection.S)
                CurrentPosition.Direction = CompassDirection.W;
            else if (CurrentPosition.Direction == CompassDirection.W)
                CurrentPosition.Direction = CompassDirection.N;
        }
    }
}