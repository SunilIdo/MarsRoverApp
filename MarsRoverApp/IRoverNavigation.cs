using System.Collections.Generic;

namespace MarsRoverApp
{
    public interface IRoverNavigation
    {
        void CalculateRoverPosition(Plateau p, List<Rover> roverList);
        void NavigateLeft(Rover r);
        void NavigateRight(Rover r);
        void MoveForward(Rover r);

    }
}
