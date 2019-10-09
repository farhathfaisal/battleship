using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace Tests
{
    [TestClass()]
    public class GameControllerTests
    {
        //Check that the difficulty gets set correctly
        [TestMethod()]
        public void SetDifficultyTest()
        {
            GameController.SetDifficulty(AIOption.Easy);
            GameController.SetAIPlayer();
            if (GameController.ComputerPlayer.GetType() != typeof(AIEasyPlayer))
            {
                Assert.AreNotEqual(GameController.ComputerPlayer.GetType(), typeof(AIEasyPlayer));
            }

            GameController.SetDifficulty(AIOption.Medium);
            GameController.SetAIPlayer();
            if (GameController.ComputerPlayer.GetType() != typeof(AIMediumPlayer))
            {
                Assert.AreNotEqual(GameController.ComputerPlayer.GetType(), typeof(AIMediumPlayer));
            }

            GameController.SetDifficulty(AIOption.Hard);
            GameController.SetAIPlayer();
            if (GameController.ComputerPlayer.GetType() != typeof(AIHardPlayer))
            {
                Assert.AreNotEqual(GameController.ComputerPlayer.GetType(), typeof(AIHardPlayer));
            }
        }

        [TestMethod]
        public void AttackResulttest()
        {
            AttackResult result = new AttackResult(ResultOfAttack.Miss, "ship1", 0, 0);
            string actual = result.ToString();
            string expected = "ship1";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Shiptest()
        {
            Ship s = new Ship(ShipName.AircraftCarrier);
            string actual = s.ToString();
            string expect = "Ship";
            Assert.AreEqual(expect, actual);

        }
    }
}