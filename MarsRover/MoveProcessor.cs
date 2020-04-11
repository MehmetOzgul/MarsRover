using System;
using System.Collections.Generic;
using System.Text;
using HepsiBuradaCase.Entity;

namespace HepsiBuradaCase
{
    public class MoveProcessor : IMoveProcessor
    {

        public void Move(Rover rover)
        {

            switch (rover.Direction)
            {
                case 'N':
                    if (rover.Y < rover.maxY)
                    {
                        rover.Y++;
                    }
                    break;
                case 'S':
                    if (rover.Y > -1)
                    {
                        rover.Y--;
                    }
                    break;
                case 'E':
                    if (rover.X < rover.maxX)
                    {
                        rover.X++;
                    }
                    break;
                case 'W':
                    if (rover.X > -1)
                    {
                        rover.X--;
                    }
                    break;
            }
        }


        public void TurnLeft(Rover rover)
        {
            switch (rover.Direction)
            {
                case 'N':
                    rover.Direction = 'W';
                    break;
                case 'W':
                    rover.Direction = 'S';
                    break;
                case 'S':
                    rover.Direction = 'E';
                    break;
                case 'E':
                    rover.Direction = 'N';
                    break;
            }
        }


        public void TurnRight(Rover rover)
        {
            switch (rover.Direction)
            {
                case 'N':
                    rover.Direction = 'E';
                    break;
                case 'E':
                    rover.Direction = 'S';
                    break;
                case 'S':
                    rover.Direction = 'W';
                    break;
                case 'W':
                    rover.Direction = 'N';
                    break;
            }
        }
    }
}
