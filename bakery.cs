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

        public int CalcPrice(int loaves)
        {
            int price = 0;

            


            price = LoafPrice * loaves;

            return price;
        }

    }

    class Pastry
    {
        public int PastryPrice { get; set; }

        public Pastry()
        {
            PastryPrice = 2;
        }

        public int CalcPrice(int pastries)
        {
            int price = 0;

            price = PastryPrice * pastries;

            return price;
        }
    }
}