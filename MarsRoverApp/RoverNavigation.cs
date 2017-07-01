using System;
using System.Collections.Generic;
using static MarsRoverApp.Enums;

namespace MarsRoverApp
{
    public class RoverNavigation : IRoverNavigation
    {
        IHelper helper;
        public RoverNavigation()
        {
            helper = new Helper();
        }
        public void CalculateRoverPosition(Plateau p, List<Rover> roverList)
        {
            try
            {
                foreach (Rover r in roverList)
                {
                    foreach (Instruction i in r.Instructions)
                    {
                        switch (i)
                        {
                            case Instruction.L:
                                NavigateLeft(r);
                                break;
                            case Instruction.R:
                                NavigateRight(r);
                                break;
                            case Instruction.M:
                                if (helper.IsValidLandingPosition(p, r))
                                    MoveForward(r);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MoveForward(Rover r)
        {
            try
            {
                switch (r.Direction)
                {
                    case Direction.N:
                        r.Y++;
                        break;
                    case Direction.S:
                        r.Y--;
                        break;
                    case Direction.E:
                        r.X++;
                        break;
                    case Direction.W:
                        r.X--;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void NavigateLeft(Rover r)
        {
            try
            {
                switch (r.Direction)
                {
                    case Direction.N:
                        r.Direction = Direction.W;
                        break;
                    case Direction.S:
                        r.Direction = Direction.E;
                        break;
                    case Direction.E:
                        r.Direction = Direction.N;
                        break;
                    case Direction.W:
                        r.Direction = Direction.S;
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void NavigateRight(Rover r)
        {
            try
            {
                switch (r.Direction)
                {
                    case Direction.N:
                        r.Direction = Direction.E;
                        break;
                    case Direction.S:
                        r.Direction = Direction.W;
                        break;
                    case Direction.E:
                        r.Direction = Direction.S;
                        break;
                    case Direction.W:
                        r.Direction = Direction.N;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
