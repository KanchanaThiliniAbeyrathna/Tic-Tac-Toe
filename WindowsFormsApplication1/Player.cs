using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Player
    {
        private string playerName;
        private int wins;
        private int losses;
        public static int HighScore=0;


        public Player(string name)
        {
            playerName = name;
        }
        public void setWins(int w)
        {
            wins = w;
        }
        public void setLosses(int l)
        {
            losses = l;
        }
        public int getWins()
        {
            return wins;
        }
        public int getLosses()
        {
            return losses;
        }
        public string getPlayerName()
        {
            return playerName;
        }
        public void setHighScore(int w)
        {
            if (HighScore < w)
            {
                HighScore = w;
            }
        }
        public int getHighScore()
        {
            return HighScore;
        }
    }
}
