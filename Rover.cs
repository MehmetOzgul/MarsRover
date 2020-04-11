using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBuradaCase.Entity
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Direction { get; set; }

        public int maxX { get; set; }
        public int maxY { get; set; }
    }
}
