using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console.InputLayer.Parsers
{
    public class InputParser
    {
        //takes a string like "5 5" and returns a PlateauSize object with Width=5 and Height=5
        public PlateauSize ParsePlateauSize(string input)
        {
            string[] splitInput = input.Split(' ');
            if (splitInput.Length != 2)
            {
                throw new ArgumentException("Invalid input - expected: 'Width Height'");
            }

            int width = int.Parse(splitInput[0]);
            int height = int.Parse(splitInput[1]);

            PlateauSize plateauSize = new PlateauSize(width, height);
            return plateauSize;
        }

        //takes a string like "1 2 N" and returns a Position object with X=1, Y=2, Direction=N

        public Position ParsePosition(string input)
        {
            string[] splitInput = input.Split(' ');
            if (splitInput.Length != 3)
            {
                throw new ArgumentException("Invalid input - expected: 'X Y Direction'");
            }
            int x = int.Parse(splitInput[0]);
            int y = int.Parse(splitInput[1]);
            string directionLetter = splitInput[2];

            CompassDirection direction;

            if (directionLetter == "N")
            {
                direction = CompassDirection.N;
            }
            else if (directionLetter == "E")
            {
                direction = CompassDirection.E;
            }
            else if (directionLetter == "S")
            {
                direction = CompassDirection.S;
            }
            else if (directionLetter == "W")
            {
                direction = CompassDirection.W;
            }
            else
            {
                throw new ArgumentException("Invalid input - expected direction to be one of: N, E, S, W");
            }

            Position position = new Position(x, y, direction);
            return position;
        }

        //takes a string like "LMLMLMLMM" and returns a list of Instruction enums
        public List<Instruction> ParseInstructions(string input)
        {
            List<Instruction> instructions = new List<Instruction>();

            foreach (char letter in input)
            {
                if (letter == 'L')
                {
                    instructions.Add(Instruction.L);
                }
                else if (letter == 'R')
                {
                    instructions.Add(Instruction.R);
                }
                else if (letter == 'M')
                {
                    instructions.Add(Instruction.M);
                }
                else
                {
                    throw new ArgumentException("Invalid instruction - expected L, R or M only");

            }
            return instructions;
        }
    }
}


