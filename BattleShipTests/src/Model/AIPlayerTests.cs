using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class AIPlayerTests
    {
        //Test if the AI player is setup correctly
        [TestMethod()]
        public void CheckIfAIPlayerIsSetupCorrectly()
        {
            AIPlayer player;
            BattleShipsGame game = new BattleShipsGame();

            player = new AIEasyPlayer(game);
            if (player.Hits != 0) { Assert.AreNotEqual(player.Hits, 0); }
            if (player.Missed != 0) { Assert.AreNotEqual(player.Missed, 0); }
            if (player.Score != 0) { Assert.AreNotEqual(player.Score, 0); }
            if (player.Shots != 0) { Assert.AreNotEqual(player.Shots, 0); }
            if (player.ReadyToDeploy != false) { Assert.AreNotEqual(player.ReadyToDeploy, false); }
        }
    }
}