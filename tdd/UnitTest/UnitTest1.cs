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
        [TestMethod]
        public void TestGamePositionsListX()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.IsNotNull(gameHandler.positionsX);
        }
        [TestMethod]
        public void TestGamePositionsListY()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.IsNotNull(gameHandler.positionsY);
        }
        [TestMethod]
        public void TestGamePositionsListCountX()
        {
            GameHandler gameHandler = new GameHandler("", "");
            int expected = gameHandler.positionsX.Count;
            Assert.AreEqual(9, expected);
        }
        [TestMethod]
        public void TestGamePositionsListCountY()
        {
            GameHandler gameHandler = new GameHandler("", "");
            int expected = gameHandler.positionsY.Count;
            Assert.AreEqual(9, expected);
        }
        [TestMethod]
        public void TestGameTurn()
        {
            GameHandler gameHandler = new GameHandler("", "");
            Assert.IsNotNull(gameHandler.turn);
        }
    }

}
