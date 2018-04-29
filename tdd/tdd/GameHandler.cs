using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class GameHandler
    {
        public Player player1, player2;
        public GameHandler()
        {

        }
        public List<bool> positionsX, positionsY;
        public bool turn;

        public GameHandler(String name1, String name2)
        {
            player1 = new Player(name1);
            player2 = new Player(name2);
            positionsX = new List<bool>();
            positionsY = new List<bool>();
            for (int i = 0; i < 9; i++)
            {
                positionsX.Add(false);
                positionsY.Add(false);
            }
            turn = true;
        }
        public bool ifWinner(List<bool> pos)
        {
            if (pos[0] == true && pos[0] == pos[4] && pos[4] == pos[8])
                return true;
            return false;
        }

    }

    public class Player
    {
        private String name;
        public Player(String name)
        {
            this.name = name;
        }
        public Player() { }
        public String getName()
        {
            return name;
        }

    }
}
