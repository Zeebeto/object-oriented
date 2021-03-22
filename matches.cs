using System;
using System.Collections.Generic;
using System.Text;

namespace object_oriented
{
    class match
    {
        public bool isMatchrunning;
        public int homeScore;
        public int awayScore;
        public int misses;
        public string userBet;
        public string endResult;

        public match(bool running,
        string bet)
        {
            isMatchrunning = running;
            homeScore = 0;
            awayScore = 0;
            misses = 0;
            userBet = bet;
            endResult = "match not over";
        }
    }
}
