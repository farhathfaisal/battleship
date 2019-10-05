using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace battleshiptest
{
    [TestClass]
    public class UnitTest1
    {
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
