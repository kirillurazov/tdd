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
        [TestMethod]
        public void TestGameConstructorWithNames()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.IsNotNull(gameHandler);
        }
        [TestMethod]
        public void TestGameConstructorToCreatePlayers()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.IsNotNull(gameHandler.player1);
        }
        [TestMethod]
        public void TestGameConstructorToCreatePlayers2()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.IsNotNull(gameHandler.player2);
        }
    }

}
