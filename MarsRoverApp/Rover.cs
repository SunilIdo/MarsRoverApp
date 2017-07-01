using System.Collections.Generic;
using static MarsRoverApp.Enums;

namespace MarsRoverApp
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }
        public List<Instruction> Instructions { get; set; }
    }
}
