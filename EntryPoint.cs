using System;

namespace RockPaperScissors
{
    static class EntryPoint
    {
        public static void Main(string[] args)
        {
            User player1 = new User();
            Computer player2 = new Computer();
            Game.MakeHeader();
            Game.Play(player1, player2);
        }
    }
}
