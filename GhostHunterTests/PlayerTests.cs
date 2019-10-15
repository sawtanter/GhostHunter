using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GhostHunter.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void Test()
        {
            Player player = new Player();

            bool loadBullet = player.LoadBullets(6);
            bool SpinChamber = player.SpinChambers(-1);
            player.Fire();
            Assert.IsTrue(loadBullet == false, "Random number not between 0 - 5");
            Assert.IsTrue(SpinChamber == false, "Random number not between 0 - 5");
        }
    }
}