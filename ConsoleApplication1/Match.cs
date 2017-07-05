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
        { int subHelp = 0;
            foreach (Sub subs in _subs)
            {
                if (time ==subs.Min)
                {
                    _players[subs.PlayerUp].Status=false;
                    subHelp = subs.PlayerDown;
                    subs.PlayerDown = subs.PlayerUp;
                    subs.PlayerUp = subHelp;
                    _players[subs.PlayerUp].Status = true;

                }
            }
        }

        private void playerAllTime(int time)
        {
            foreach (Players player in _players)
            {
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
