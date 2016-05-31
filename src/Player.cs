using System;

namespace RockPaperScissors
{
    class Player
    {
        public int score = 0;
        public void RaiseScore()
        {
            this.score += 1;
        }
    }
}
