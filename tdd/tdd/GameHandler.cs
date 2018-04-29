using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class GameHandler
    {
        public GameHandler()
        {

        }

        public GameHandler(String name1, String name2)
        {
            
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
