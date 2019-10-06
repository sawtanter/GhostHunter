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
        public void Test()
        {
            Player player = new Player();

            Boolean loadBullet = player.LoadBullets(6);
            Boolean SpinChamber = player.SpinChambers(-1);
            player.Fire();
            Assert.IsTrue(loadBullet == false, "Random number not between 0 - 5");
            Assert.IsTrue(SpinChamber == false, "Random number not between 0 - 5");
        }
    }
}