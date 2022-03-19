// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System;
class MainClass
{
    public static void Main(string[] args)
    {
        double water = 0;
        double soda = 0;
        double buffet = 5.99;
        bool cycle = true;

        do
        {

            Console.WriteLine("Hello, welcome to our buffet.  All you can eat for $9.99.  Water is free and soda is $2.00, no parties larger than 6 please.  How many today?");
            int input = Int32.Parse(Console.ReadLine());


            if (input > 6 || input <= 0)
            {
                Console.WriteLine("Sorry, we can't make that work. :(");
                cycle = false;
                break;
            }
            else
            {
                Console.WriteLine("Great, right this way.");
            }


            Console.WriteLine("Take a seat, let's get everyone started with some drinks.");

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine($"Okay, person {i}, what would you like to drink?");
                string drinkOrder = Console.ReadLine();

                if (drinkOrder == "soda")
                {
                    Console.WriteLine("Soda, great choice.");
                }
                else if (drinkOrder == "water")
                {
                    Console.WriteLine("Water, great choice.");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have that.  Stay thirsty my friend.");
                }


                if (drinkOrder == "water")
                {
                    water++;
                }
                if (drinkOrder == "soda")
                {
                    soda++;
                }
                if (i >= input)
                {
                    Console.WriteLine($"Great, so we have {water} waters and {soda} sodas");
                    double totalBill = 9.99 * input + soda * 2;
                    Console.WriteLine($"Here are your drinks, feel free to grab your food.  The total is ${totalBill}");
                    cycle = false;
                    break;
                }
            }






        } while (cycle);
        Console.WriteLine("Have a nice day!");






    }
}
