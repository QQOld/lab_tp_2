using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_tp2
{
    class CardSelector
    {
        static Random random = new Random();

        public static int GenerateSuitNumber()
        {
            return random.Next(1, 5);
        }

        public static int GenerateValueNumber()
        {
            return random.Next(1, 10);
        }

        public static void ChooseCard()
        {
            Console.WriteLine("Вы выбрали " + Deck.values[GenerateValueNumber()] + " " + Deck.suits[GenerateSuitNumber()]);
        }
    }
}
