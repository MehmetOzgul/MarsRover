using HepsiBuradaCase.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBuradaCase
{
    public class Processor
    {

        public readonly IMoveProcessor _moveProcessor;
        public Processor(IMoveProcessor moveProcessor)
        {
            _moveProcessor = moveProcessor;
        }
        public void Run(string moves, Rover rover)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'L':
                        _moveProcessor.TurnLeft(rover);
                        break;
                    case 'R':
                        _moveProcessor.TurnRight(rover);
                        break;
                    case 'M':
                        _moveProcessor.Move(rover);
                        break;
                }
            }
        }
    }
}
