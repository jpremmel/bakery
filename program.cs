using System;
using System.Text.RegularExpressions;
using Bakery;

class Program
{
    static void Main()
    {
        Console.WriteLine("~ Welcome to Pierre's Bakery! ~");
        Console.WriteLine("~ One loaf of bread: $5. *Pierre's Deal: Buy two, get one free!* ~");
        Console.WriteLine("~ One pastry: $2. *Pierre's Deal: Buy three pastries for $5!* ~");
        Console.WriteLine("How many loaves of bread would you like to purchase?");
        string breadInput = Console.ReadLine();
        Console.WriteLine("How many pastries would you like to purchase?");
        string pastryInput = Console.ReadLine();
        Regex regex = new Regex(@"^[0-9]+$");
        Match breadMatch = regex.Match(breadInput);
        Match pastryMatch = regex.Match(pastryInput);
        if (breadMatch.Success && pastryMatch.Success)
        {
            int loaves = int.Parse(breadInput);
            Bread bread = new Bread();
            int breadPrice = bread.CalcPrice(loaves);
            int pastries = int.Parse(pastryInput);
            Pastry pastry = new Pastry();
            int pastryPrice = pastry.CalcPrice(pastries);
            int totalPrice = breadPrice + pastryPrice;
            Console.WriteLine("Your total price: $" + totalPrice);


            Console.WriteLine("bread.LoafPrice: " + bread.LoafPrice);
            bread.LoafPrice = 8;
            Console.WriteLine("bread.LoafPrice: " + bread.LoafPrice);

        }
        else
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Numerical input only. Please try again.");
            Console.WriteLine("---------------------------------------");
            Main();
        }  
    }
}