using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_tp2
{
    public class Deck
    {

        public static Dictionary<int, String> suits = new Dictionary<int, String>
        {
            {1, "Черви" },
            {2, "Бубны"},
            {3, "Треф"},
            {4, "Пики"}    
        };


        public static Dictionary<int, String> values = new Dictionary<int, String>
        {
            {1, "6" },
            {2, "7"},
            {3, "8"},
            {4, "9"},
            {5, "10"},
            {6, "Валет"},
            {7, "Дама"},
            {8, "Король"},
            {9, "Туз" }
        };
    }
}
