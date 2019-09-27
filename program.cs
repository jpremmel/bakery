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
        int loaves = 0;
        Regex regex = new Regex(@"^[0-9]+$");
        string loavesInput = Console.ReadLine();
        Match match = regex.Match(loavesInput);
        if (match.Success)
        {

        }
        // try
        // {
        //     loaves = int.Parse(Console.ReadLine());
        // }
        // catch (System.FormatException)
        // {
        //     Console.WriteLine("---------------------------------------");
        //     Console.WriteLine("Numerical input only. Please try again.");
        //     Console.WriteLine("---------------------------------------");
        //     loaves = int.Parse(Console.ReadLine());
        // }
        Bread bread = new Bread();
        int breadPrice = bread.CalcPrice(loaves);
        Console.WriteLine("How many pastries would you like to purchase?");
        int pastries = 0;
        // try
        // {
        //     pastries = int.Parse(Console.ReadLine());
        // }
        // catch (System.FormatException)
        // {
        //     Console.WriteLine("---------------------------------------");
        //     Console.WriteLine("Numerical input only. Please try again.");
        //     Console.WriteLine("---------------------------------------");
        //     pastries = int.Parse(Console.ReadLine());
        // }
        Pastry pastry = new Pastry();
        int pastryPrice = pastry.CalcPrice(pastries);
        int totalPrice = breadPrice + pastryPrice;
        Console.WriteLine("Your total price: $" + totalPrice);
    }
}