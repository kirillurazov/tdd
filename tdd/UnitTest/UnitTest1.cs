using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGameHandler()
        {
            GameHandler game = new GameHandler();
            Assert.IsNotNull(game);
        }
        [TestMethod]
        public void TestPlayerCreate()
        {
            Player player = new Player();
            Assert.IsNotNull(player);
        }
    }
}
