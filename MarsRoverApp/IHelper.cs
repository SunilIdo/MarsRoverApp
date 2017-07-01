using System.Collections.Generic;

namespace MarsRoverApp
{
    public interface IHelper
    {
        bool IsValidLandingPosition(Plateau p, Rover r);
        void InitializeInputs();
        Plateau GetPlateau();
        List<Rover> GetRovers();
        void DisplayOutput();

    }
}
