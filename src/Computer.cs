using System;

namespace RockPaperScissors
{
    class Computer : Player
    {
        public Choice Choose()
        {
            Random rnd = new Random();
            Array choices = Enum.GetValues(typeof(Choice));
            return (Choice)choices.GetValue(rnd.Next(choices.Length));
        }
    }
}
