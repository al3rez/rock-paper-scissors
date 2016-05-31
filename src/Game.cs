using System;

namespace RockPaperScissors
{
    class Game
    {
        public static void Play(User player1, Computer player2)
        {
            for (int i = 1; i <= 3; i++)
            {
                Choice user = player1.Choose();
                Choice computer = player2.Choose();
                string outcome = Logic.Compare(user, computer);

                if (outcome == "user")
                {
                    player1.RaiseScore();
                    Console.WriteLine("you won!");
                }
                else if (outcome == "computer")
                {
                    player2.RaiseScore();
                    Console.WriteLine("computer won!");
                }
                else if (outcome == "none")
                    Console.WriteLine("draw");
                else
                    PlayAgain(player1, player2);

                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("you: {0} | computer: {1}", player1.score, player2.score);

        }

        public static void PlayAgain(User player1, Computer player2)
        {
            Console.WriteLine("game Over.");
            Console.WriteLine("would you like to play again?");
            string choice = Console.ReadLine();

            if (choice == "y" || choice == "Y")
                Play(player1, player2);
            else if (choice == "n" || choice == "N")
                Environment.Exit(0);
            else
            {
                Console.WriteLine("wrong input, please try again!");
                PlayAgain(player1, player2);
            }
        }

        public static void MakeHeader()
        {
            Console.WriteLine("#########################################");
            Console.WriteLine("########## rock paper scissors ##########");
            Console.WriteLine("#########################################");
        }
    }
}
