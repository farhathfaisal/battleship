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
            if (GameController.ComputerPlayer.GetType() != typeof(Nullable))
            {
                Assert.Fail("ai player was not set correctly");
            }

            GameController.SetDifficulty(AIOption.Medium);
            GameController.SetAIPlayer();
            if (GameController.ComputerPlayer.GetType() != typeof(AIMediumPlayer))
            {
                Assert.Fail("ai player was not set correctly");
            }

            GameController.SetDifficulty(AIOption.Hard);
            GameController.SetAIPlayer();
            if (GameController.ComputerPlayer.GetType() != typeof(AIHardPlayer))
            {
                Assert.Fail("ai player was not set correctly");
            }
        }
    }
}