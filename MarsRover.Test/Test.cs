using HepsiBuradaCase;
using HepsiBuradaCase.Entity;
using System;
using Xunit;

namespace Test
{
    public class Test
    {
        [Fact]
        public void Should_Returns_1_3_N()
        {

            var rover = new Rover() { Direction = 'N', X = 1, Y = 2, maxX = 5, maxY = 5 };
            var moves = "LMLMLMLMM";
            new Processor(new MoveProcessor()).Run(moves, rover);
            Assert.Equal("1 3 N", rover.X + " " + rover.Y + " " + rover.Direction);
        }

        [Fact]
        public void Should_Returns_5_1_E()
        {
            var rover = new Rover() { Direction = 'E', X = 3, Y = 3, maxX = 5, maxY = 5 };
            var moves = "MMRMMRMRRM";
            new Processor(new MoveProcessor()).Run(moves, rover);
            Assert.Equal("5 1 E", rover.X + " " + rover.Y + " " + rover.Direction);
        }
    }
}
