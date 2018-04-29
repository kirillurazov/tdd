﻿using System;
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

        public GameHandler(String name1, String name2)
        {
            player1 = new Player(name1);
            player2 = new Player(name2);
            positionsX = new List<bool>();
            positionsY = new List<bool>();
            for(int i = 0; i<9;i++)
            {
                positionsX[i] = false;
            }
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
