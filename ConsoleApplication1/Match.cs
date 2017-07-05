using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Match
    {
        readonly Players[] _players;
        readonly Sub[] _subs;


        public Match (Players[] players, Sub[] subs)
        {

            _subs = subs;
            _players = players;
        }


        private void isPlayerup(int time)
        {
            foreach (Sub subs in _subs)
            {
                if (time ==subs.Min)
                {
                    _players[subs.PlayerUp-1].Status=false;
                    _players[subs.PlayerDown-1].Status = true;

                }
            }
        }

        private void playerAllTime(int time)
        {
            foreach (Players player in _players)
            {
                isPlayerup(time);

                if (player.Status)
                {
                    player.Minutes++;
                }
            }
   
        }
        public void PlayMatch()
        {
            for (int i = 0; i < 60; i++)
            {
                playerAllTime(i);
               
            }
        }
    }
}
