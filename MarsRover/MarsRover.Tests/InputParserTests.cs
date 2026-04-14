using MarsRover.Console.InputLayer;
using MarsRover.Console.InputLayer.Parsers;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class InputParserTests
    {
        private InputParser parser;

        [SetUp]
        public void SetUp()
        {
            parser = new InputParser();
        }

        // =====================
        // ParsePlateauSize tests
        // =====================

        [Test]
        public void ParsePlateauSize_Returns_Correct_Width_And_Height()
        {
            PlateauSize result = parser.ParsePlateauSize("5 5");
            Assert.That(result.Width, Is.EqualTo(5));
            Assert.That(result.Height, Is.EqualTo(5));
        }

        [Test]
        public void ParsePlateauSize_Returns_Correct_Width_And_Height_For_Rectangle()
        {
            PlateauSize result = parser.ParsePlateauSize("10 20");
            Assert.That(result.Width, Is.EqualTo(10));
            Assert.That(result.Height, Is.EqualTo(20));
        }

        [Test]
        public void ParsePlateauSize_Throws_Exception_For_Invalid_Input()
        {
            Assert.That(() => parser.ParsePlateauSize("5"), Throws.TypeOf<ArgumentException>());
        }

        // =====================
        // ParsePosition tests
        // =====================

        [Test]
        public void ParsePosition_Returns_Correct_X_And_Y_And_Facing()
        {
            Position result = parser.ParsePosition("1 2 N");
            Assert.That(result.X, Is.EqualTo(1));
            Assert.That(result.Y, Is.EqualTo(2));
            Assert.That(result.Direction, Is.EqualTo(CompassDirection.N));
        }

        [Test]
        public void ParsePosition_Returns_Correct_Direction_For_Each_Compass_Point()
        {
            Assert.That(parser.ParsePosition("0 0 N").Direction, Is.EqualTo(CompassDirection.N));
            Assert.That(parser.ParsePosition("0 0 S").Direction, Is.EqualTo(CompassDirection.S));
            Assert.That(parser.ParsePosition("0 0 E").Direction, Is.EqualTo(CompassDirection.E));
            Assert.That(parser.ParsePosition("0 0 W").Direction, Is.EqualTo(CompassDirection.W));
        }

        [Test]
        public void ParsePosition_Throws_Exception_For_Invalid_Direction()
        {
            Assert.That(() => parser.ParsePosition("1 2 X"), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void ParsePosition_Throws_Exception_For_Invalid_Input()
        {
            Assert.That(() => parser.ParsePosition("1 2"), Throws.TypeOf<ArgumentException>());
        }

        // =====================
        // ParseInstructions tests
        // =====================

        [Test]
        public void ParseInstructions_Returns_Correct_List_Of_Instructions()
        {
            List<Instruction> result = parser.ParseInstructions("LMRM");
            Assert.That(result.Count, Is.EqualTo(4));
            Assert.That(result[0], Is.EqualTo(Instruction.L));
            Assert.That(result[1], Is.EqualTo(Instruction.M));
            Assert.That(result[2], Is.EqualTo(Instruction.R));
            Assert.That(result[3], Is.EqualTo(Instruction.M));
        }

        [Test]
        public void ParseInstructions_Throws_Exception_For_Invalid_Characters()
        {
            Assert.That(() => parser.ParseInstructions("LMRHADR"), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void ParseInstructions_Returns_Empty_List_For_Empty_String()
        {
            List<Instruction> result = parser.ParseInstructions("");
            Assert.That(result.Count, Is.EqualTo(0));
        }

    }
}
