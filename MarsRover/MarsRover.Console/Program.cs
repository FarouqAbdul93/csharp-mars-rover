using MarsRover.Console.InputLayer.Parsers;

// create a new parser
InputParser parser = new InputParser();

// the example input from the brief
string plateauInput = "5 5";
string rover1Position = "1 2 N";
string rover1Instructions = "LMLMLMLMM";
string rover2Position = "3 3 E";
string rover2Instructions = "MMRMMRMRRM";

// parse the plateau size
var plateau = parser.ParsePlateauSize(plateauInput);
Console.WriteLine("Plateau size: " + plateau.Width + " x " + plateau.Height);

// parse rover 1
var position1 = parser.ParsePosition(rover1Position);
Console.WriteLine("Rover 1 starting position: " + position1.X + " " + position1.Y + " " + position1.Direction);

var instructions1 = parser.ParseInstructions(rover1Instructions);
Console.WriteLine("Rover 1 instructions count: " + instructions1.Count);

// parse rover 2
var position2 = parser.ParsePosition(rover2Position);
Console.WriteLine("Rover 2 starting position: " + position2.X + " " + position2.Y + " " + position2.Direction);

var instructions2 = parser.ParseInstructions(rover2Instructions);
Console.WriteLine("Rover 2 instructions count: " + instructions2.Count);