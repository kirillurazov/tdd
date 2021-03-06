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
        public bool turn;
        public int stroke;

        public GameHandler(String name1, String name2)
        {
            player1 = new Player(name1);
            player2 = new Player(name2);
            positionsX = new List<bool>();
            positionsY = new List<bool>();
            stroke = 0;
            for (int i = 0; i < 9; i++)
            {
                positionsX.Add(false);
                positionsY.Add(false);
            }
            turn = true;
        }
        public GameHandler(String name1, String name2, bool t, int p1, int p2)
        {
            player1 = new Player(name1, p1);
            player2 = new Player(name2, p2);
            positionsX = new List<bool>();
            positionsY = new List<bool>();
            stroke = 0;
            for (int i = 0; i < 9; i++)
            {
                positionsX.Add(false);
                positionsY.Add(false);
            }
            turn = t;
        }
        public bool ifWinner(List<bool> pos)
        {
            if (pos.Count != 9)
                return false;
            if (pos[0] == true && pos[0] == pos[4] && pos[4] == pos[8])
                return true;
            else if (pos[1] == true && pos[1] == pos[4] && pos[4] == pos[7]) 
                return true;
            else if (pos[2] == true && pos[2] == pos[5] && pos[5] == pos[8])
                return true;
            else if (pos[0] == true && pos[0] == pos[3] && pos[3] == pos[6])
                return true;
            else if (pos[0] == true && pos[0] == pos[1] && pos[1] == pos[2])
                return true;
            else if (pos[3] == true && pos[3] == pos[4] && pos[4] == pos[5])
                return true;
            else if (pos[6] == true && pos[6] == pos[7] && pos[7] == pos[8])
                return true;
            else if (pos[2] == true && pos[2] == pos[4] && pos[4] == pos[6])
                return true;
            return false;
        }

    }

    public class Player
    {
        private String name;
        public int points;
        public Player(String name)
        {
            this.name = name;
            points = 0;
        }
        public Player(String name, int p)
        {
            this.name = name;
            points = p;
        }
        public Player() { }
        public String getName()
        {
            return name;
        }

    }
}
