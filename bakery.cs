using System;

namespace Bakery
{
    class Bread
    {
        private int _loafPrice;
        public int LoafPrice
        { 
            get
            {
                return _loafPrice;
            }
            set
            {
                Console.WriteLine("To change the price, you will need special override permission from Pierre. Please contact him directly.");
            }
        
        }
        public Bread()
        {
            _loafPrice = 5;
        }
        public int CalcPrice(int loaves)
        {
            int price = (loaves / 3) * (LoafPrice * 2) + (LoafPrice * (loaves % 3));
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
            int price = (pastries / 3) * 5 + (PastryPrice * (pastries % 3));
            return price;
        }
    }
}