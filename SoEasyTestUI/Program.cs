using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoEasy;

namespace SoEasyUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "banana abacaxi morango chocolate";
            string between = text.Between("abacaxi", "chocolate", true); // Return morango

            DateTime day = DateTime.Now;
            string when = day.When(); // Return Today

            day = DateTime.Now.AddDays(-1);
            when = day.When(); // Return Yesterday

            day = DateTime.Now.AddDays(1);
            when = day.When(); // Return Tomorrow
        }
    }
}
