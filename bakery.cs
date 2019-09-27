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
                Console.WriteLine("To change the loaf price, you will need special override permission from Pierre. Please contact him directly.");
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
        private int _pastryPrice;
        public int PastryPrice
        { 
            get
            {
                return _pastryPrice;
            }
            set
            {
                Console.WriteLine("To change the pastry price, you will need special override permission from Pierre. Please contact him directly.");
            }
        }
        public Pastry()
        {
            _pastryPrice = 2;
        }
        public int CalcPrice(int pastries)
        {
            int price = (pastries / 3) * 5 + (PastryPrice * (pastries % 3));
            return price;
        }
    }
}