using HepsiBuradaCase.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBuradaCase
{
    public interface IMoveProcessor
    {
        void TurnLeft(Rover rover);
        void TurnRight(Rover rover);
        void Move(Rover rover);
    }
}
