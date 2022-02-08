using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattren
{
public    class Meal
    {
        private string sandWich;
        private string fries;
        private string drink;
        public string Drink { get; set; }
        public string Fries { get; set; }
        public string Sandwich { get; set; }

        public override string ToString()
        {
            return string.Format($"Drink:\t\t{Drink}\nFries:\t\t{Fries}\nSandwich:\t\t{Sandwich}\n");
        }

    }
}
