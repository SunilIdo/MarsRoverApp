using System;
using System.Collections.Generic;
using System.Linq;
using static MarsRoverApp.Enums;

namespace MarsRoverApp
{
    public class Helper : IHelper
    {
        private Plateau plateau;
        private List<Rover> rovers;
        private List<Rover> inputRovers;
        public void InitializeInputs()
        {
            plateau = new Plateau(5, 5);
            rovers = new List<Rover>();
            string ins1 = "LMLMLMLMM";
            Rover r1 = new Rover() { X = 1, Y = 2, Direction = Direction.N, Instructions = ins1.Select(c => (Instruction)Enum.Parse(typeof(Instruction), c.ToString(), true)).ToList() };
            rovers.Add(r1);
            string ins2 = "MMRMMRMRRM";
            Rover r2 = new Rover() { X = 3, Y = 3, Direction = Direction.E, Instructions = ins2.Select(c => (Instruction)Enum.Parse(typeof(Instruction), c.ToString(), true)).ToList() };
            rovers.Add(r2);
            inputRovers = new List<Rover>();
            inputRovers = rovers;
        }

        public Plateau GetPlateau()
        {
            return plateau;
        }

        public List<Rover> GetRovers()
        {
            return rovers;
        }

        public bool IsValidLandingPosition(Plateau p, Rover r)
        {
            int currentX = r.X;
            int currentY = r.Y;
            bool result = false;
            try
            {
                switch (r.Direction)
                {
                    case Direction.N:
                        currentY++;
                        result = currentY <= p.RightY;
                        break;
                    case Direction.S:
                        currentY--;
                        result = currentY >= 0;
                        break;
                    case Direction.E:
                        currentX++;
                        result = currentX <= p.RightX;
                        break;
                    case Direction.W:
                        currentX--;
                        result = currentX >= 0;
                        break;
                    default:
                        break;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DisplayOutput()
        {
            Console.WriteLine("Inputs:");
            Console.WriteLine(plateau.RightX + " " + plateau.RightY);
            foreach (Rover r in inputRovers)
            {
                Console.Write(r.X + " " + r.Y + " " + r.Direction + "\n" + string.Join("", r.Instructions.Select(i => i.ToString())) + "\n");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Output:");
            foreach (Rover r in rovers)
            {
                Console.Write(r.X + " " + r.Y + " " + r.Direction + "\n");
            }
        }
    }
}
