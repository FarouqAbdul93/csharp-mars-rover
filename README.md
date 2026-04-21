🚀 C# Mars Rover Simulator
A C# console application that simulates NASA-style Mars rover navigation. Rovers are deployed onto a rectangular plateau and controlled via a series of movement instructions, with the final position of each rover reported on completion.
Built as part of the Northcoders Enterprise Engineering Bootcamp (C# / .NET), with a focus on clean architecture, object-oriented design, and Test-Driven Development.

📋 How It Works
The program takes a text-based input describing a plateau and one or more rovers:
5 5          ← Width and height of the plateau grid
1 2 N        ← Rover 1 starting position (x, y, facing direction)
LMLMLMLMM   ← Rover 1 movement instructions
3 3 E        ← Rover 2 starting position
MMRMMRMRRM  ← Rover 2 movement instructions
Instructions:

L — Rotate 90° left (without moving)
R — Rotate 90° right (without moving)
M — Move forward one grid square in the current direction

Expected output:
1 3 N
5 1 E

🏗️ Architecture
The project is built using a layered architecture, keeping each concern cleanly separated:
Input Layer   →   Parses raw string input into strongly-typed data models
Logic Layer   →   Processes movement instructions and updates rover positions
UI Layer      →   Handles user interaction and displays results
This design means the movement logic is completely independent of the input format — instructions could come from a terminal, a file, a web form, or unit tests, and the logic layer wouldn't need to change.
Key Classes & Types
FileResponsibilityInputParser.csParses plateau size, rover positions, and instruction stringsCompassDirection (enum)Represents valid directions: N, S, E, WInstruction (enum)Represents valid commands: L, R, MPosition.csData model holding x, y coordinates and facing directionProgram.csEntry point — coordinates the layers

🧪 Testing
The project follows Test-Driven Development (TDD) — tests were written before implementation using the Red → Green → Refactor cycle.
Tests cover:

Parsing valid plateau dimensions
Parsing valid and invalid rover positions
Parsing instruction sequences
Rover movement and rotation logic
Edge cases and invalid input (throws ArgumentException)

Test framework: xUnit with Moq for test doubles

🛠️ Tech Stack

Language: C# / .NET
IDE: Visual Studio 2022
Testing: xUnit, Moq
Version Control: Git / GitHub
Methodology: TDD, OOP, Layered Architecture


🚀 Getting Started
Prerequisites

.NET SDK (version 8 or above)
Visual Studio 2022 or any terminal with dotnet installed

Run the application
bashgit clone https://github.com/FarouqAbdul93/csharp-mars-rover.git
cd csharp-mars-rover
dotnet run --project MarsRover
Run the tests
bashdotnet test

👨‍💻 Author
Farouq H Abdullah

GitHub: github.com/FarouqAbdul93
Email: farouqha93@gmail.com
