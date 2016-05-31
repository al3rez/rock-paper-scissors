using System;

namespace RockPaperScissors
{
    class User : Player
    {
        public Choice Choose()
        {

            Console.Write("do you choose (r)ock, (p)aper or (s)cissors? ");
            string input = Console.ReadLine();
            Choice choice;

            if (input == "r")
            {
                Console.WriteLine(Gesture.ROCK);
                return Choice.ROCK;
            }
            else if (input == "p")
            {
                Console.WriteLine(Gesture.PAPER);
                return Choice.PAPER;
            }
            else if (input == "s")
            {
                Console.WriteLine(Gesture.SCISSORS);
                return Choice.SCISSORS;
            }
            else
            {
                Console.WriteLine("wrong input, please try again.\n");
                choice = Choose();
            }

            return choice;
        }

    }
}
