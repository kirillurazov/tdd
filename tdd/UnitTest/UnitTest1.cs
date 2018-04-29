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
        /*[TestMethod]
        public void TestPlayerCreateWithName()
        {
            Player player = new Player("name");
            string name = player.name;
            Assert.AreEqual(name, "name");
        }*/
        [TestMethod]
        public void TestPlayerGettername()
        {
            Player player = new Player("програмуктер");
            string name = player.getName();
            Assert.AreEqual(name, "програмуктер");
        }
    }
}
