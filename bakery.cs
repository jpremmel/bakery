using System;

namespace Bakery
{
    class Bread
    {
        public int LoafPrice { get; set; }

        public Bread()
        {
            LoafPrice = 5;
        }

    }

    class Pastry
    {
        public int PastryPrice { get; set; }

        public Pastry()
        {
            PastryPrice = 2;
        }
    }
}