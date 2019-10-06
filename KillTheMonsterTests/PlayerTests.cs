using Microsoft.VisualStudio.TestTools.UnitTesting;
using KillTheMonster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillTheMonster.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void FireTest()
        {
            //Arrange
            Player player = new Player();
            Boolean lb = player.LoadBullets(6);
            Boolean sc = player.SpinChambers(-1);
            Assert.IsTrue(lb == true,"Random number not between 0 - 5");
            Assert.IsTrue(sc == true, "Random number not between 0 - 5");
            Assert.Fail();
        }
    }
}