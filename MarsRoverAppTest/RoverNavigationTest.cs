using MarsRoverApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static MarsRoverApp.Enums;

namespace MarsRoverAppTest
{
    [TestClass]
    public class RoverNavigationTest
    {
        IRoverNavigation objRN;
        IHelper helper;
        Plateau plateau;
        List<Rover> rovers;

        [TestInitialize]
        public void TestSetUp()
        {
            helper = new Helper();
            helper.InitializeInputs();
            plateau = helper.GetPlateau();
            rovers = helper.GetRovers();
            objRN = new RoverNavigation();
        }

        [TestMethod]
        public void MoveForwardTest()
        {
            Rover r4 = new Rover();
            r4.Direction = Direction.N;
            r4.X = 1;
            r4.Y = 2;
            objRN.MoveForward(r4);
            Assert.AreEqual(3, r4.Y);
        }

        [TestMethod]
        public void NavigateLeftTest()
        {
            Rover r2 = new Rover();
            r2.Direction = Direction.N;
            r2.X = 3;
            r2.Y = 4;
            objRN.NavigateLeft(r2);
            Assert.AreEqual(Direction.W, r2.Direction);
        }

        [TestMethod]
        public void NavigateRightTest()
        {
            Rover r3 = new Rover();
            r3.Direction = Direction.E;
            r3.X = 2;
            r3.Y = 1;
            objRN.NavigateRight(r3);
            Assert.AreEqual(Direction.S, r3.Direction);
        }

        [TestMethod]
        public void CalculateRoverPositionTest()
        {
            List<Rover> _rovers = new List<Rover>();
            Rover r1 = new Rover() { X = 1, Y = 3, Direction = Direction.N };
            Rover r2 = new Rover() { X = 5, Y = 1, Direction = Direction.E };
            objRN.CalculateRoverPosition(plateau, rovers);
            Assert.IsTrue(AreRoversEqual(_rovers, rovers));
        }
        private bool AreRoversEqual(List<Rover> rovers1, List<Rover> rovers2)
        {
            bool flag = true;
            for (int i = 0; i < rovers1.Count; i++)
            {
                if (!(rovers1[i].X.Equals(rovers2[i].X) && rovers1[i].Y.Equals(rovers2[i].Y) && rovers1[i].Direction.Equals(rovers2[i].Direction)))
                    flag = false;
            }
            return flag;
        }
    }
}
