using HepsiBuradaCase.Entity;
using System;

namespace HepsiBuradaCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = Console.ReadLine().Trim().Split(' ');
            var positions = Console.ReadLine().Trim().Split(' ');
            var moves = Console.ReadLine();

            var rover = new Rover
            {
                X = int.Parse(positions[0]),
                Y = int.Parse(positions[1]),
                Direction = Char.Parse(positions[2]),
                maxX = int.Parse(capacity[0]),
                maxY = int.Parse(capacity[1])
            };
            new Processor(new MoveProcessor()).Run(moves, rover);
            Console.Write(rover.X + " " + rover.Y + rover.Direction);
            Console.ReadKey();
        }

    
    }


   

  






}
