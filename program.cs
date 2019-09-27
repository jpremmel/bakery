using System;
using Bakery;

class Program
{
    static void Main()
    {
        Console.WriteLine("~ Welcome to Pierre's Bakery! ~");
        Console.WriteLine("~ One loaf of bread: $5. *Deal: Buy two, get one free!* ~");
        Console.WriteLine("~ One pastry: $2. *Deal: Buy three pastries for $5!* ~");

        Console.WriteLine("How many loaves of bread would you like to purchase?");
        int loaves = int.Parse(Console.ReadLine());
        Bread bread = new Bread();
        int breadPrice = bread.CalcPrice(loaves);

        Console.WriteLine("How many pastries would you like to purchase?");
        int pastries = int.Parse(Console.ReadLine());
        Pastry pastry = new Pastry();
        int pastryPrice = pastry.CalcPrice(pastries);
        
        int totalPrice = breadPrice + pastryPrice;
        Console.WriteLine("Your total price: $" + totalPrice);
    }
}