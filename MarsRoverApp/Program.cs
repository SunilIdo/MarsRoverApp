using System;
using System.Collections.Generic;

namespace MarsRoverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IHelper helper = new Helper();
            helper.InitializeInputs();
            Plateau plateau = helper.GetPlateau();
            List<Rover> roverList = helper.GetRovers();
            IRoverNavigation objRN = new RoverNavigation();
            objRN.CalculateRoverPosition(plateau, roverList);
            helper.DisplayOutput();
            Console.ReadKey();
        }
    }
}
