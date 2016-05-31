using System;

namespace RockPaperScissors
{
    class Logic
    {
        public static string Compare(Choice computer, Choice user)
        {
            if (user == Choice.ROCK && computer == Choice.PAPER)
                return "computer";
            else if (user == Choice.ROCK && computer == Choice.SCISSORS)
                return "user";
            else if (user == Choice.ROCK && computer == Choice.ROCK)
                return "none";
            else if (user == Choice.PAPER && computer == Choice.ROCK)
                return "user";
            else if (user == Choice.PAPER && computer == Choice.SCISSORS)
                return "computer";
            else if (user == Choice.PAPER && computer == Choice.PAPER)
                return "none";
            else if (user == Choice.SCISSORS && computer == Choice.ROCK)
                return "computer";
            else if (user == Choice.SCISSORS && computer == Choice.PAPER)
                return "user";
            else if (user == Choice.SCISSORS && computer == Choice.SCISSORS)
                return "none";

            return "none";
        }
    }
}
